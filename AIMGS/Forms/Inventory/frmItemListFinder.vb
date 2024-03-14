Imports PowerNET8.myNumber.Share.Formatter
Imports PowerNET8.myString.Share

Public Class frmItemListFinder
    Dim onClickActivate As Boolean = False
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Public action As String = ""
    Public itemID As Integer = 0

    Private Sub frmItemListFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect(mysql)
        reloadGrid()
        If action = "use" Then cmdAdd.Text = "Select"
    End Sub

    Private Sub reloadGrid(Optional ByVal wh As String = "")
        If wh <> "" Then wh = " where " + wh
        Dim mydata As DataTable = mysql.Query("SELECT * from tblinventory_item " + wh)
        dgvDetails.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvDetails
                .Rows.Add()
                With .Rows(i)
                    .Cells(0).Value = mydata.Rows(i).Item("itemID")
                    .Cells(1).Value = mysql.getImage(mydata.Rows(i).Item("itemID"), "itemID", "file", "field_size", "tblinventory_item_img")
                    .Cells(2).Value = mydata.Rows(i).Item("productName")
                    .Cells(3).Value = format_DecimalOnly(mydata.Rows(i).Item("dprice"), 2)
                    .Cells(4).Value = format_DecimalOnly(mydata.Rows(i).Item("profit"), 2)
                    .Cells(5).Value = format_DecimalOnly(mydata.Rows(i).Item("srp"), 2)
                End With
            End With
        Next
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click, cmdEdit.Click, cmdSearch.Click, cmdDelete.Click, cmdView.Click, cmdReset.Click
        Dim frm As New frmItemList
        With frm
            Select Case CType(sender, Button).Text
                Case "Search"
                    Dim wh As String = ""
                    If txtSearchName.Text <> "" Then Concat.Append(wh, " productName like " + "'" + txtSearchName.Text + "%'", " and ")
                    reloadGrid(wh)
                    txtSearchName.Text = ""
                Case "Reset"
                    txtSearchName.Text = ""
                    reloadGrid()
                Case "Add"
                    .action = "add"
                    .ShowDialog()
                Case "Edit"
                    If onClickActivate Then
                        .itemID = dgvDetails.CurrentRow.Cells(0).Value.ToString
                        .action = "edit"
                        .ShowDialog()
                    Else
                        MsgBox("Please select a record to edit", MsgBoxStyle.Information, "Unable to proceed")
                    End If
                Case "View"
                    If onClickActivate Then
                        .itemID = dgvDetails.CurrentRow.Cells(0).Value.ToString
                        .action = "view"
                        .ShowDialog()
                    Else
                        MsgBox("Please select a record to view", MsgBoxStyle.Information, "Unable to proceed")
                    End If
                Case "Delete"
                    If onClickActivate Then
                        If MsgBox("Do you want to remove this selected item?", MsgBoxStyle.YesNo, "Delete Confirm") = MsgBoxResult.Yes Then
                            mysql.Query("DELETE FROM tblinventory_item where itemID=" + dgvDetails.CurrentRow.Cells(0).Value.ToString)
                            cmdAdd_Click(cmdSearch, Nothing)
                        End If
                    Else
                        MsgBox("Please select a record to delete", MsgBoxStyle.Information, "Unable to proceed")
                    End If
                Case "Select"
                    If onClickActivate Then
                        itemID = dgvDetails.CurrentRow.Cells(0).Value.ToString
                        Me.Close()
                    Else
                        MsgBox("Please select an item", MsgBoxStyle.Information, "Unable to proceed")
                    End If
            End Select
        End With
    End Sub

    Private Sub dgvDetails_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellClick
        onClickActivate = True
    End Sub

    Private Sub dgvDetails_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellDoubleClick
        If dgvDetails.RowCount > 0 Then
            If action = "use" Then
                cmdAdd_Click(cmdAdd, Nothing)
            Else
                cmdAdd_Click(cmdView, Nothing)
            End If
        End If
    End Sub

    Private Sub txtSearchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdAdd_Click(cmdSearch, Nothing)
        End If
    End Sub

    Private Sub dgvDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellContentClick

    End Sub
End Class