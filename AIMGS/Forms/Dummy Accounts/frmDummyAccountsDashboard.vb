Public Class frmDummyAccountsDashboard
    Private mysql As New PowerNET8.mySQL.Init.SQL


    Private Function getCountDummyRecords(ByVal table As String, ByVal where As String) As Integer
        Dim mydata As DataTable = mysql.Query("SELECT count(*) from " + table + " where CreatedBy=" + userID.ToString + "  " + where)
        Return mydata.Rows(0).Item(0)
    End Function

    Private Sub reloadDummyAccountsRecordStatus()
        lblAllDummies.Text = getCountDummyRecords("tbldummy_accounts", "").ToString + "/20"
        lblDActive.Text = getCountDummyRecords("tbldummy_accounts", " and accountStatus='Active'").ToString
        lblDInactive.Text = getCountDummyRecords("tbldummy_accounts", " and accountStatus='Inactive'").ToString
        lblDblocked.Text = getCountDummyRecords("tbldummy_accounts", " and accountStatus='Blocked'").ToString
    End Sub

    Private Sub initialize()
        connect(mysql)
        reloadDummyAccountsRecordStatus()
    End Sub

    Private Sub frmDummyAccountsDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub csRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles csRefresh.Click
        reloadDummyAccountsRecordStatus()
    End Sub

    Private Sub Dummies_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblAllDummies.LinkClicked, lblDActive.LinkClicked, lblDInactive.LinkClicked, lblDblocked.LinkClicked
        Dim frm As New frmDummyAccountFinder
        With frm
            Select Case CType(sender, LinkLabel).Name
                Case "lblAllDummies"
                    .Show()
                Case "lblDActive"
                    .cboAccountStatus.SelectedIndex = 0
                    .Show()
                Case "lblDInactive"
                    .cboAccountStatus.SelectedIndex = 1
                    .Show()
                Case "lblDblocked"
                    .cboAccountStatus.SelectedIndex = 2
                    .Show()
            End Select
        End With
    End Sub

    Private Sub cmdTodoList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTodoList.Click
        My.Computer.Audio.Play("sound effects\click.wav")
    End Sub

    Private Sub cmdTodoList_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTodoList.MouseEnter
        My.Computer.Audio.Play("sound effects\hover.wav")
    End Sub
End Class