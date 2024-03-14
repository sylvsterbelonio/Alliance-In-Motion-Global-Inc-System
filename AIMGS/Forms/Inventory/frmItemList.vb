Imports PowerNET8.myNumber.Share.Formatter
Public Class frmItemList
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private clsObjects As New clsObjects
    Private colObject As New Collection
    Private reqObject As New Collection

    Public itemID As Integer = 0
    Public action As String = "add"


    Private Sub frmItemList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub initialize()
        connect(mysql)
        setObjects()
        clsObjects.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, New ToolStripButton)
        clsObjects.setObjectParameters(colObject)
        setUp()
    End Sub

    Private Sub setUp()
        Select Case action
            Case "add"
                With clsObjects
                    .toolstripNavigation(AIMGS.clsObjects.ToolAction.add)
                    .Clear_All(colObject)
                End With

            Case "edit"
                reloadRecord()
                With clsObjects
                    .toolstripNavigation(AIMGS.clsObjects.ToolAction.edit)
                    .Lock_Mode_All(colObject, AIMGS.clsObjects.Lock.No)
                End With
            Case "view"
                reloadRecord()
                With clsObjects
                    .toolstripNavigation(AIMGS.clsObjects.ToolAction.view)
                    .Lock_Mode_All(colObject, AIMGS.clsObjects.Lock.Yes)
                End With
        End Select

    End Sub


    Private Sub reloadRecord()
        Dim mydata As DataTable = mysql.Query("SELECT * FROM tblinventory_item where itemID=" + itemID.ToString)
        If mydata.Rows.Count > 0 Then
            txtProductName.Text = mydata.Rows(0).Item("productName")
            txtDescription.Text = mydata.Rows(0).Item("description")
            txtCommissionalPoints.Text = format_DecimalOnly(mydata.Rows(0).Item("com_pnts"), 0)
            txtPositionalPoints.Text = format_DecimalOnly(mydata.Rows(0).Item("pos_pnts"), 4)
            txtDistributorPrice.Text = format_DecimalOnly(mydata.Rows(0).Item("dprice"), 2)
            txtProfit.Text = format_DecimalOnly(mydata.Rows(0).Item("profit"), 2)
            txtSRP.Text = format_DecimalOnly(mydata.Rows(0).Item("srp"), 2)
            txtRemarks.Text = mydata.Rows(0).Item("remarks")
            pcImage.Image = mysql.getImage(itemID.ToString, "itemID", "file", "field_size", "tblinventory_item_img")
        End If
    End Sub

    Private Sub setObjects()
        With colObject
            .Clear()
            .Add(txtProductName)
            .Add(txtDescription)
            .Add(txtCommissionalPoints)
            .Add(txtPositionalPoints)
            .Add(txtDistributorPrice)
            .Add(txtProfit)
            .Add(txtSRP)
            .Add(txtRemarks)
            .Add(pcImage)
        End With
        With reqObject
            .Clear()
            .Add(txtProductName)
            .Add(txtCommissionalPoints)
            .Add(txtDistributorPrice)
            .Add(txtPositionalPoints)
            .Add(txtProfit)
            .Add(txtSRP)
        End With
    End Sub

    Private Sub txtCommissionalPoints_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCommissionalPoints.LostFocus
        sender.Text = format_DecimalOnly(sender.text, 0)
    End Sub

    Private Sub txtPositionalPoints_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPositionalPoints.LostFocus
        sender.Text = format_DecimalOnly(sender.text, 4)
    End Sub

    Private Sub txtDistributorPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDistributorPrice.LostFocus, txtProfit.LostFocus, txtSRP.LostFocus
        sender.Text = format_DecimalOnly(sender.text, 2)
        If CType(sender, TextBox).Name = "txtSRP" Or CType(sender, TextBox).Name = "txtDistributorPrice" Then
            txtProfit.Text = format_DecimalOnly((txtSRP.Text) - CDbl(txtDistributorPrice.Text), 2)
        End If
    End Sub

    Private Sub txtCommissionalPoints_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCommissionalPoints.MouseClick, txtDistributorPrice.MouseClick, txtPositionalPoints.MouseClick, txtPositionalPoints.MouseClick
        sender.selectall()
    End Sub

    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsEdit.Click, tsCancel.Click, tsSave.Click
        Select Case CType(sender, ToolStripButton).Text
            Case "Add"
                action = "add"
                itemID = 0
                clsObjects.Lock_Mode_All(colObject, AIMGS.clsObjects.Lock.No)
                clsObjects.Clear_All(colObject)
                pcImage.ImageLocation = ""
                pcImage.Refresh()
                txtProductName.Focus()
                clsObjects.toolstripNavigation(AIMGS.clsObjects.ToolAction.add)
            Case "Save"
                If clsObjects.validateFields(reqObject) Then
                    With mysql
                        .setTable("tblinventory_item")
                        .addValue(txtProductName, "productName")
                        .addValue(txtDescription, "description")
                        .addValue(CDbl(txtCommissionalPoints.Text), "com_pnts")
                        .addValue(CDbl(txtPositionalPoints.Text), "pos_pnts")
                        .addValue(CDbl(txtDistributorPrice.Text), "dprice")
                        .addValue(CDbl(txtProfit.Text), "profit")
                        .addValue(CDbl(txtSRP.Text), "srp")
                        .addValue(txtRemarks.Text, "remarks")
                        If itemID = 0 Then
                            itemID = .nextID("itemID")
                            .addValue(itemID, "itemID")
                            .addValue(userID, "createdBy")
                            .addValue(userID, "updatedBy")
                            .addValue(clsObjects.getCurrentDate, "dtUpdated")
                            .Insert()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "New Record Added")
                        Else
                            .addValue(userID, "updatedBy")
                            .addValue(clsObjects.getCurrentDate, "dtUpdated")
                            .Update("itemID", itemID)
                            MsgBox("You have successfully updated the record", MsgBoxStyle.Information, "New Record Added")
                        End If
                        
                    End With

                    If pcImage.ImageLocation <> "" Then
                        mysql.Query("DELETE FROM tblinventory_item_img where itemID=" + itemID.ToString)
                        mysql.saveImage(itemID, txtProductName.Text.Replace(" ", "") + "_img", pcImage.ImageLocation.ToString, "itemID", "file", "filename", "field_size", "tblinventory_item_img")
                    End If

                    clsObjects.Lock_Mode_All(colObject, AIMGS.clsObjects.Lock.Yes)
                    clsObjects.toolstripNavigation(AIMGS.clsObjects.ToolAction.save)
                End If
            Case "Edit"
                action = "edit"
                With clsObjects
                    .toolstripNavigation(AIMGS.clsObjects.ToolAction.edit)
                    .Lock_Mode_All(colObject, AIMGS.clsObjects.Lock.No)
                End With
            Case "Cancel"
                If action = "add" Then Me.Close()
                With clsObjects
                    .toolstripNavigation(AIMGS.clsObjects.ToolAction.view)
                    .Lock_Mode_All(colObject, AIMGS.clsObjects.Lock.Yes)
                End With
        End Select
    End Sub

    Private Sub lnkUpload_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkUpload.LinkClicked
        Dim browser As New PowerNET8.myBrowseDialog
        pcImage.ImageLocation = browser.browseImage()
        pcImage.Refresh()
    End Sub

    Private Sub lnkRemove_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRemove.LinkClicked
        pcImage.ImageLocation = ""
        pcImage.Refresh()
    End Sub
End Class