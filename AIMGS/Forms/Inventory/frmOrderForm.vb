Imports PowerNET8.myNumber.Share.Formatter
Public Class frmOrderForm
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private itemID As Integer = 0
    Private orderNo As String = ""

    Private Sub frmOrderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect(mysql)
        udtDateOrdered.Value = Now
        autosuggest()
    End Sub

    Private Sub autosuggest()
        Dim mydata As DataTable = mysql.Query("SELECT distinct bco from tblinventory_item_order")
        With txtBCO
            For i As Integer = 0 To mydata.Rows.Count - 1
                .AutoCompleteCustomSource.Add(mydata.Rows(i).Item(0))
            Next
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteMode = AutoCompleteMode.Append
        End With
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        Dim frmItemFinder As New frmItemListFinder
        With frmItemFinder
            .action = "use"
            .ShowDialog()
            If .itemID > 0 Then
                Dim mydata As DataTable = mysql.Query("SELECT * FROM tblinventory_item where itemID=" + .itemID.ToString)
                If mydata.Rows.Count > 0 Then
                    itemID = .itemID
                    lblProductName.Text = mydata.Rows(0).Item("productName")
                    lblDistributorPrice.Text = format_DecimalOnly(mydata.Rows(0).Item("dprice"), 2)
                    pcImage.Image = mysql.getImage(.itemID, "itemID", "file", "field_size", "tblinventory_item_img")
                    cmdSelect.Visible = False
                    txtQuantity.Value = 1
                End If
            End If
        End With
    End Sub

    Private Sub cmdDecline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecline.Click
        cmdSelect.Visible = True
        lblDistributorPrice.Text = "0.00"
        lblProductName.Text = "-"
        pcImage.Image = Nothing
        pcImage.Refresh()
        trigger_status()
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        With dgvDetails
            .Rows.Add()
            With .Rows(.RowCount - 1)
                .Cells(0).Value = itemID
                .Cells(1).Value = mysql.getImage(itemID, "itemID", "file", "field_size", "tblinventory_item_img")
                .Cells(2).Value = lblProductName.Text
                .Cells(3).Value = lblDistributorPrice.Text
                .Cells(4).Value = txtQuantity.Value
                .Cells(5).Value = format_DecimalOnly(CDbl(lblDistributorPrice.Text) * txtQuantity.Value, 2)
            End With
        End With
        cmdDecline_Click(cmdDecline, Nothing)
    End Sub

    Private Sub dgvDetails_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellClick
        Select Case dgvDetails.CurrentCell.ColumnIndex
            Case 6
                dgvDetails.Rows.Remove(dgvDetails.CurrentRow)
                trigger_status()
        End Select
    End Sub

    Private Sub trigger_status()
        Dim tot_quantity As Double = 0
        Dim tot_price As Double = 0
        For i As Integer = 0 To dgvDetails.RowCount - 1
            tot_quantity += CDbl(dgvDetails.Rows(i).Cells(4).Value)
            tot_price += CDbl(dgvDetails.Rows(i).Cells(5).Value)
        Next
        lblQuantityOrdered.Text = format_DecimalOnly(tot_quantity, 0)
        lblAmountOrdered.Text = format_DecimalOnly(tot_price, 2)
        lblTypeItems.Text = dgvDetails.RowCount
    End Sub

    Private Sub dgvDetails_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvDetails.RowStateChanged
        If dgvDetails.RowCount > 0 Then
            cmdOrderNow.Enabled = True
        Else
            cmdOrderNow.Enabled = False
        End If
    End Sub

    Private Function zerofill(ByVal value As String)
        Select Case value.Length
            Case 1
                Return "0000000" + value
            Case 2
                Return "000000" + value
            Case 3
                Return "00000" + value
            Case 4
                Return "0000" + value
            Case 5
                Return "000" + value
            Case 6
                Return "00" + value
            Case 7
                Return "0" + value
            Case Else
                Return value
        End Select
    End Function

    Private Sub cmdOrderNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrderNow.Click
        With mysql
            .setTable("tblinventory_item_order")
            orderNo = zerofill(.nextID("orderID"))
        End With

        'this is for saving the history of the items
        For i As Integer = 0 To dgvDetails.RowCount - 1
            With mysql
                .setTable("tblinventory_item_order")
                .addValue(.nextID("orderID"), "orderID")
                .addValue(txtBCO.Text, "bco")
                .addValue(orderNo, "orderCode")
                .addValue(dgvDetails.Rows(i).Cells(0).Value, "itemID")
                .addValue(CDbl(dgvDetails.Rows(i).Cells(4).Value), "quantity")
                .addValue(CDbl(dgvDetails.Rows(i).Cells(5).Value), "totPrice")
                .addValue(udtDateOrdered.Value, "orderedDate")
                .Insert()
            End With
        Next

        'event to add new items into your available inventory
        For i As Integer = 0 To dgvDetails.RowCount - 1
            Dim itemID = dgvDetails.Rows(i).Cells(0).Value
            Dim myitem As DataTable = mysql.Query("SELECT * FROM tblinventory_available_items where itemID=" + itemID.ToString)
            If myitem.Rows.Count > 0 Then
                'available item and the item will be added
                Dim curQuantity As Double = myitem.Rows(0).Item("quantity")
                curQuantity += CDbl(dgvDetails.Rows(i).Cells(4).Value)
                With mysql
                    .setTable("tblinventory_available_items")
                    .addValue(curQuantity, "quantity")
                    .Update("itemID", itemID.ToString)
                End With
            Else
                'means new item to your inventory
                With mysql
                    .setTable("tblinventory_available_items")
                    .addValue(itemID, "itemID")
                    .addValue(CDbl(dgvDetails.Rows(i).Cells(4).Value), "quantity")
                    .Insert()
                End With
            End If
        Next





        MsgBox("Items have been ordered and now available at your inventory!")
        Me.Close()
    End Sub
End Class