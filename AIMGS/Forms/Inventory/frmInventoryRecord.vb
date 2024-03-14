Imports PowerNET8.myNumber.Share.Formatter
Public Class frmInventoryRecord
    Private mysql As New PowerNET8.mySQL.Init.SQL

    Private Sub frmInventoryRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect(mysql)
        refreshAvailableInventory()


    End Sub

    Private Sub getItemTypeAvailable()
        Dim mydata As DataTable = mysql.Query("SELECT * from tblinventory_available_items")
        lblItemTypeAvailable.Text = format_DecimalOnly(mydata.Rows.Count, 0)
    End Sub

    Private Sub getItemAvailable()
        Dim mydata As DataTable = mysql.Query("SELECT SUM(quantity) from tblinventory_available_items")
        lblitemAvailable.Text = format_DecimalOnly(mydata.Rows(0).Item(0), 0)
    End Sub

    Private Sub getItemQuantityOrdered()
        Dim mydata As DataTable = mysql.Query("SELECT SUM(quantity) from tblinventory_item_order")
        lblItemQOrdered.Text = format_DecimalOnly(mydata.Rows(0).Item(0), 0)
    End Sub

    Private Sub getTypeItems()
        Dim mydata As DataTable = mysql.Query("SELECT *  from tblinventory_item")
        lblTypeItems.Text = format_DecimalOnly(mydata.Rows.Count, 0)
    End Sub

    Private Sub refreshAvailableInventory()
        Dim mydata As DataTable = mysql.Query("SELECT tblinventory_available_items.itemID, productName,quantity FROM  tblinventory_item  INNER JOIN aimgs.tblinventory_available_items     ON (tblinventory_item.itemID = tblinventory_available_items.itemID)")
        dgvDetails.Rows.Clear()
        For i As Integer = 0 To mydata.Rows.Count - 1
            With dgvDetails
                .Rows.Add()
                With .Rows(i)
                    .Cells(0).Value = mydata.Rows(i).Item("itemID")
                    .Cells(1).Value = mysql.getImage(mydata.Rows(i).Item("itemID"), "itemID", "file", "field_size", "tblinventory_item_img")
                    .Cells(2).Value = mydata.Rows(i).Item("productName")
                    .Cells(3).Value = mydata.Rows(i).Item("quantity")
                End With
            End With
        Next
        getItemTypeAvailable()
        getItemAvailable()
        getTypeItems()
        getItemQuantityOrdered()
    End Sub

    Private Sub cmdItemConfig_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdItemConfig.Click
        Dim frm As New frmItemListFinder
        frm.ShowDialog()
    End Sub

    Private Sub cmdOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrder.Click
        Dim frm As New frmOrderForm
        frm.ShowDialog()
        refreshAvailableInventory()
    End Sub


End Class