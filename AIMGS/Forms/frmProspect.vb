Public Class frmProspect
    Private mytoolstrip As New clsObjects
    Private colObjects As New Collection
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Public action As String = "add"


    Private Sub loadObjects()
        With colObjects
            .Add(txtFirstName)
            .Add(txtMiddleName)
            .Add(txtLastName)
            .Add(optF)
            .Add(optM)
            .Add(cboDay)
            .Add(cboMonth)
            .Add(txtFB)
            .Add(txtYear)
            .Add(txtRemarks)
            .Add(txtMNo)
            .Add(cboStatus)
        End With
    End Sub

    Private Sub initialize()
        connect(mysql)
        loadObjects()
        mytoolstrip.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, tsPrint)
        clsObjects.setTextSkin(colObjects)
        cboMonth.SelectedIndex = Now.Month - 1
        cboDay.Text = Now.Day
        txtYear.Text = Now.Year
    End Sub

    Private Sub frmProspect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub


    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsCancel.Click, tsEdit.Click, tsPrint.Click, tsSave.Click
        Select Case CType(sender, ToolStripButton).Text
            Case "Add"
                clsObjects.Clear_All(colObjects)
                txtFirstName.Focus()

            Case "Save"
                With mysql
                    .setTable("tblpersonal_info")
                    .addValue(txtFirstName, "firstName")
                    .addValue(txtMiddleName, "middleName")
                    .addValue(txtLastName, "surName")
                    If optM.Checked Then
                        .addValue("M", "gender")
                    Else
                        .addValue("F", "gender")
                    End If
                    .addValue(txtYear.Text + "-" + cboMonth.Text + "-" + cboDay.Text, "birthdate")
                    .addValue(txtFB, "fbLink")
                    .addValue(txtMNo, "mobileNo")
                    .addValue(cboStatus.Text, "status")
                    .addValue(txtRemarks, "remarks")
                End With
            Case "Edit"
            Case "Cancel"
            Case "Print"

        End Select
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click

    End Sub
End Class