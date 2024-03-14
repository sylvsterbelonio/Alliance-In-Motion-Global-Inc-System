Imports PowerNET8.myString.Share
Public Class frmDummyAccount
    Public action As String = "add"
    Public DAID As Integer = 0
    Private clsObjects As New clsObjects
    Private colObject As New Collection
    Private reqObject As New Collection
    Private mysql As New PowerNET8.mySQL.Init.SQL

    Private Sub initialize()
        connect(mysql)
        setObjects()
        clsObjects.assignToolStrip(tsAdd, tsEdit, tsSave, tsCancel, New ToolStripButton)
        clsObjects.setTextSkin(colObject)
        autosuggest()
        setUp()
    End Sub

    Private Sub setObjects()
        With colObject
            .Clear()
            .Add(cboType)
            .Add(txtMobileNumber)
            .Add(txtPassword)
            .Add(txtOFirstName)
            .Add(txtOMiddleName)
            .Add(txtOSurname)
            .Add(txtFFirstName)
            .Add(txtFSurname)
            .Add(txtFMiddleName)
            .Add(txtEmailAddress)
            .Add(cboMonth)
            .Add(cboDay)
            .Add(txtYear)
            .Add(cboAccountStatus)
            .Add(txtRemarks)
        End With
        With reqObject
            .Clear()
            .Add(cboType)
            .Add(txtMobileNumber)
            .Add(txtFFirstName)
            .Add(txtFSurname)
            .Add(cboMonth)
            .Add(cboDay)
        End With
    End Sub

    Private Sub autosuggest()
        clsObjects.setAutoSuggestTextBox("mobileNumber", "tbldummy_accounts", " where createdBy=" + userID.ToString, txtMobileNumber, mysql)

        clsObjects.setAutoSuggestTextBox("oFname", "tbldummy_accounts", " where createdBy=" + userID.ToString, txtOFirstName, mysql)
        clsObjects.setAutoSuggestTextBox("oMname", "tbldummy_accounts", " where createdBy=" + userID.ToString, txtOMiddleName, mysql)
        clsObjects.setAutoSuggestTextBox("oSname", "tbldummy_accounts", " where createdBy=" + userID.ToString, txtOSurname, mysql)

        clsObjects.setAutoSuggestTextBox("fFname", "tbldummy_accounts", " where createdBy=" + userID.ToString, txtFFirstName, mysql)
        clsObjects.setAutoSuggestTextBox("fMname", "tbldummy_accounts", " where createdBy=" + userID.ToString, txtFMiddleName, mysql)
        clsObjects.setAutoSuggestTextBox("fSname", "tbldummy_accounts", " where createdBy=" + userID.ToString, txtFSurname, mysql)
    End Sub

    Private Sub frmDummyAccount_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Play("sound effects\closing form.wav", AudioPlayMode.Background)
    End Sub

    Private Sub frmDummyAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        My.Computer.Audio.Play("sound effects\opening form.wav", AudioPlayMode.Background)
    End Sub

    Private Sub reloadRecord()
        Dim mydata As DataTable = mysql.Query("SELECT * FROM tbldummy_accounts where DAID=" + DAID.ToString)
        If mydata.Rows.Count > 0 Then
            With mydata.Rows(0)
                cboType.Text = .Item("accountType")
                txtMobileNumber.Text = .Item("mobileNumber")
                txtEmailAddress.Text = .Item("emailAddress")
                chkAutogenerate.Checked = .Item("autoGenerate")
                txtPassword.Text = EnDecryption.Execute(.Item("password"))
                txtOFirstName.Text = .Item("oFname")
                txtOMiddleName.Text = .Item("oMname")
                txtOSurname.Text = .Item("oSname")
                txtFFirstName.Text = .Item("fFname")
                txtFMiddleName.Text = .Item("fMname")
                txtFSurname.Text = .Item("fSname")
                Dim col() As String = .Item("birthdate").ToString.Split("-")
                txtYear.Value = Val(col(0))
                cboMonth.SelectedIndex = (Val(col(1)) - 1)
                cboDay.Text = col(2)
                cboAccountStatus.Text = .Item("accountStatus")
                txtRemarks.Text = .Item("remarks")
            End With
        Else
            MsgBox("No data loaded", MsgBoxStyle.Exclamation, "Error")
            Me.Close()
        End If
    End Sub

    Private Sub setUp()
        With txtYear
            .Maximum = Now.Year
            .Value = Now.Year
        End With
        Select Case action
            Case "add"
                With clsObjects
                    .toolstripNavigation(AIMGS.clsObjects.ToolAction.add)
                    .Clear_All(colObject)
                End With
                cboType.SelectedIndex = 0
                cboMonth.SelectedIndex = 0
                cboDay.SelectedIndex = 0
                cboAccountStatus.SelectedIndex = 0
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

#Region "CUSTOM CODES"

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.Text = "Mobile Number" Then
            'lblAccountType.Text = "Mobile No."
            txtEmailAddress.Enabled = False
            chkAutogenerate.Enabled = False
        Else
            If cboType.Text <> "-Select Account Type-" Then
                'lblAccountType.Text = "Email Address"
                chkAutogenerate.Enabled = True
                txtEmailAddress.Enabled = True
            Else
                'lblAccountType.Text = "-"
                chkAutogenerate.Enabled = False
                txtEmailAddress.Enabled = False
            End If

        End If
        txtMobileNumber.Text = ""
        txtEmailAddress.Text = ""
        txtMobileNumber.Focus()
    End Sub

    Private Sub cmdView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdView.MouseDown
        txtPassword.PasswordChar = ""
    End Sub

    Private Sub cmdView_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdView.MouseUp
        txtPassword.PasswordChar = "*"
    End Sub

    Private Function autogenerateEmails()
        Dim value As String = ""
        Select Case cboType.Text
            Case "Gmail"
                value = "@gmail.com"
            Case "Yahoomail"
                value = "@yahoo.com"
            Case "Outlook"
                value = "@outlook.com"
        End Select

        Dim concat As String = ""
        If txtFFirstName.Text <> "" Then
            If concat = "" Then
                concat = LCase(txtFFirstName.Text)
            Else
                concat += "." + LCase(txtFFirstName.Text)
            End If
        End If
        If txtFMiddleName.Text <> "" Then
            If concat = "" Then
                concat = LCase(txtFMiddleName.Text)
            Else
                concat += "." + LCase(txtFMiddleName.Text)
            End If
        End If
        If txtFSurname.Text <> "" Then
            If concat = "" Then
                concat = LCase(txtFSurname.Text)
            Else
                concat += "." + LCase(txtFSurname.Text)
            End If
        End If
        If chkAutogenerate.Checked And (cboType.SelectedIndex <> 0) And cboType.SelectedIndex <> 1 Then
            txtMobileNumber.Text = concat + value
        End If
    End Function

    Private Sub txtFFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFFirstName.TextChanged
        autogenerateEmails()
    End Sub

    Private Sub txtFMiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFMiddleName.TextChanged
        autogenerateEmails()
    End Sub

    Private Sub txtFSurname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFSurname.TextChanged
        autogenerateEmails()
    End Sub


#End Region

    Private Sub tsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdd.Click, tsSave.Click, tsEdit.Click, tsCancel.Click
        Select Case CType(sender, ToolStripButton).Text
            Case "Add"
                action = "add"
                DAID = 0
                setUp()
                clsObjects.Lock_Mode_All(colObject, AIMGS.clsObjects.Lock.No)
            Case "Save"
                If clsObjects.validateFields(reqObject) Then
                    With mysql
                        .setTable("tbldummy_accounts")
                        .addValue(cboType, "accountType")
                        .addValue(txtMobileNumber, "mobileNumber")
                        .addValue(txtEmailAddress, "emailAddress")
                        .addValue(IIf(chkAutogenerate.Checked, 1, 0), "autoGenerate")
                        .addValue(EnDecryption.Execute(txtPassword.Text), "password")
                        .addValue(txtOFirstName, "oFname")
                        .addValue(txtOMiddleName, "oMname")
                        .addValue(txtOSurname, "oSname")
                        .addValue(txtFFirstName, "fFname")
                        .addValue(txtFMiddleName, "fMname")
                        .addValue(txtFSurname, "fSname")
                        .addValue(cboAccountStatus, "accountStatus")
                        .addValue(txtRemarks.Text, "remarks")
                        .addValue(txtYear.Value.ToString + "-" + (cboMonth.SelectedIndex + 1).ToString + "-" + cboDay.Text.ToString, "birthdate")
                        .addValue(Now, "dtUpdated")
                        .addValue(userID, "UpdatedBy")

                        If DAID = 0 Then
                            DAID = .nextID("DAID")
                            .addValue(DAID, "DAID")
                            .addValue(userID, "CreatedBy")
                            .Insert()
                            MsgBox("You have successfully added new record", MsgBoxStyle.Information, "New Record Added")
                            clsObjects.setHistoryMark("Dummy Account", "add record", "New Dummy Account Added: [" + txtFFirstName.Text + " " + txtFSurname.Text + "].          Date Created:" + Now.ToString)
                        Else
                            .Update("DAID", DAID.ToString)
                            MsgBox("You have successfully updated the record", MsgBoxStyle.Information, "Record Updated")
                            clsObjects.setHistoryMark("Dummy Account", "update record", "Old Dummy Account Updated: [" + txtFFirstName.Text + " " + txtFSurname.Text + "].          Date Updated:" + Now.ToString)
                        End If


                    End With
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

    Private Sub txtEmailAddress_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtEmailAddress.MouseClick
        txtEmailAddress.SelectAll()
    End Sub

    Private Sub txtMobileNumber_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMobileNumber.MouseClick
        txtMobileNumber.SelectAll()
    End Sub

End Class