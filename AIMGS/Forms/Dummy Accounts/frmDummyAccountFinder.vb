Imports PowerNET8.myString.Share
Public Class frmDummyAccountFinder
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Private colObject As New Collection
    Private clsObject As New clsObjects
    Private onClickActivate As Boolean = False

    Private Sub initialize()
        connect(mysql)
        cboSearchType.SelectedIndex = 0
        cboAccountType.SelectedIndex = 4
        cboAccountStatus.SelectedIndex = 3
        setData()
    End Sub

    Private Sub setData()
        With myNav
            .set_class(mysql)
            .Set_SELECT("DAID,accountType as 'ACCOUNT TYPE',  concat(oSname,', ', oFname,' ', oMname) as 'ORIGINAL NAME', concat(fSname,', ', fFname,' ',fMname) as 'FAKE NAME',emailAddress as 'EMAIL ADDRESS',mobileNumber as 'MOBILE NUMBER',birthdate as 'BIRTHDATE', accountStatus as 'ACCOUNT STATUS'")
            .Set_FROM("tbldummy_accounts")
            .Set_WHERE("CreatedBy=" + userID.ToString)
            .Set_ORDER("mobileNumber,accountType,oSname,fSname")
            .Set_Data(dgvDetails)
            .Execute()
        End With
        With dgvDetails
            .Columns(0).Visible = False
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With colObject
            .Clear()
            .Add(txtSearchName)
            .Add(txtMobileNumber)
        End With
        clsObjects.setTextSkin(colObject)
    End Sub

    Private Sub frmDummyAccountFinder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Play("sound effects\closing form.wav", AudioPlayMode.Background)
    End Sub

    Private Sub frmDummyAccountFinder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
        My.Computer.Audio.Play("sound effects\opening form.wav", AudioPlayMode.Background)
    End Sub

    Private Function getFieldPersonName()
        Select Case cboSearchType.SelectedIndex
            Case 1
                Return " oFname "
            Case 2
                Return " oMname "
            Case 3
                Return " oSname "
            Case 4
                Return " fFname "
            Case 5
                Return " fMname "
            Case 6
                Return " fSname "
            Case Else
                Return Nothing
        End Select
    End Function

    Private Sub Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click, cmdDelete.Click, cmdEdit.Click, cmdReset.Click, cmdSearch.Click, cmdView.Click, cmdAdd.Click
        My.Computer.Audio.Play("sound effects\click.wav", AudioPlayMode.WaitToComplete)
        Dim frm As New frmDummyAccount
        With frm
            Select Case CType(sender, Button).Text
                Case "Search"
                    Dim wh As String = ""
                    If txtSearchName.Text <> "" Then Concat.Append(wh, getFieldPersonName() + " like " + "'" + txtSearchName.Text + "%'", " and ")
                    If cboAccountType.SelectedIndex <> 4 Then Concat.Append(wh, " accountType = '" + cboAccountType.Text + "'", " and ")
                    If cboAccountStatus.SelectedIndex <> 3 Then Concat.Append(wh, " accountStatus = '" + cboAccountStatus.Text + "'", " and ")
                    If wh <> "" Then wh = " and " + wh
                    myNav.Set_WHERE(" CreatedBy = " + userID.ToString + wh)
                    myNav.Execute()
                Case "Reset"
                    cboSearchType.SelectedIndex = 0
                    txtSearchName.Text = ""
                    cboAccountStatus.SelectedIndex = 3
                    cboAccountType.SelectedIndex = 4
                    Buttons_Click(cmdSearch, Nothing)
                Case "Add"
                    .action = "add"
                    .ShowDialog()
                Case "Edit"
                    If onClickActivate Then
                        .DAID = dgvDetails.CurrentRow.Cells(0).Value.ToString
                        .action = "edit"
                        .ShowDialog()
                    Else
                        MsgBox("Please select a record to edit", MsgBoxStyle.Information, "Unable to proceed")
                    End If
                Case "View"
                    If onClickActivate Then
                        .DAID = dgvDetails.CurrentRow.Cells(0).Value.ToString
                        .action = "view"
                        .ShowDialog()
                    Else
                        MsgBox("Please select a record to view", MsgBoxStyle.Information, "Unable to proceed")
                    End If
                Case "Delete"
                    If onClickActivate Then
                        If MsgBox("Do you want to remove this dummy account?", MsgBoxStyle.YesNo, "Delete Confirm") = MsgBoxResult.Yes Then
                            mysql.Query("DELETE FROM tbldummy_accounts where DAID=" + dgvDetails.CurrentRow.Cells(0).Value.ToString)
                            Buttons_Click(cmdSearch, Nothing)
                        End If
                    Else
                        MsgBox("Please select a record to delete", MsgBoxStyle.Information, "Unable to proceed")
                    End If
            End Select
        End With
    End Sub

    Private Sub cboSearchType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchType.SelectedIndexChanged
        With txtSearchName
            If cboSearchType.SelectedIndex = 0 Then
                .Enabled = False
            Else
                .Enabled = True
                .Focus()
            End If
            .Text = ""
        End With
    End Sub

    Private Sub txtSearchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchName.KeyDown
        If e.KeyCode = Keys.End Then
            Buttons_Click(cmdSearch, Nothing)
        End If
    End Sub

    Private Sub cboAccountType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAccountType.SelectedIndexChanged
        Buttons_Click(cmdSearch, Nothing)
    End Sub

    Private Sub cboAccountStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAccountStatus.SelectedIndexChanged
        Buttons_Click(cmdSearch, Nothing)
    End Sub

    Private Sub dgvDetails_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellClick
        onClickActivate = True
    End Sub

    Private Sub dgvDetails_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellDoubleClick
        If dgvDetails.RowCount > 0 Then
            Buttons_Click(cmdView, Nothing)
        End If
    End Sub

    Private Sub dgvDetails_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvDetails.RowStateChanged
        If dgvDetails.RowCount > 0 Then
            cmdEdit.Enabled = True
            cmdView.Enabled = True
            cmdDelete.Enabled = True
            csEdit.Enabled = True
            csView.Enabled = True
            csDelete.Enabled = True
        Else
            cmdEdit.Enabled = False
            cmdView.Enabled = False
            cmdDelete.Enabled = False
            csEdit.Enabled = False
            csView.Enabled = False
            csDelete.Enabled = False
        End If
    End Sub

    Private Sub csAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles csAdd.Click, csView.Click, csDelete.Click, csEdit.Click
        Select Case CType(sender, ToolStripMenuItem).Text
            Case "Add"
                Buttons_Click(cmdAdd, Nothing)
            Case "Edit"
                Buttons_Click(cmdEdit, Nothing)
            Case "View"
                Buttons_Click(cmdView, Nothing)
            Case "Delete"
                Buttons_Click(cmdDelete, Nothing)
        End Select
    End Sub

    Private Sub myNav_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myNav.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtSearchName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchName.TextChanged

    End Sub

    Private Sub txtMobileNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileNumber.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub cmdAdd_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.MouseEnter, cmdSearch.MouseEnter, cmdReset.MouseEnter, cmdEdit.MouseEnter, cmdView.MouseEnter, cmdDelete.MouseEnter
        My.Computer.Audio.Play("sound effects\hover.wav", AudioPlayMode.Background)
    End Sub
End Class