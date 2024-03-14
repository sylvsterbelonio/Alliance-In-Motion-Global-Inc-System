Public Class imgLevelUp
    Public cLevel As Integer = 0
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim frm As New frmLevelUp
        frm.cLevel = cLevel
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub imgLevelUp_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub imgLevelUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("sound effects\level up full.wav", AudioPlayMode.Background)
    End Sub
End Class