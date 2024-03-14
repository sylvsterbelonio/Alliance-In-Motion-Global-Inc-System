Imports PowerNET8.myNumber.Share.Formatter
Public Class frmLevelUp
    Private mysql As New PowerNET8.mySQL.Init.SQL
    Public cLevel As Integer = 0
    Private Sub frmLevelUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cLevel += 1
        connect(mysql)
        'get the current next level balance
        Dim mydata As DataTable = mysql.Query("select * from tblexperience where UID=" + userID.ToString)
        Dim nxtLevelBalance As Integer = mydata.Rows(0).Item("nextLvl")
        'get the next level balance
        mydata = mysql.Query("SELECT * FROM tblexperience_next_level_list where level=" + cLevel.ToString)
        lvlLevel.Text = mydata.Rows(0).Item("level")
        imgRank.ImageLocation = "rank\" + mydata.Rows(0).Item("imgLocation")
        lblRank.Text = mydata.Rows(0).Item("rank")
        txtNextRank.Text = "* Your next experience level is " + format_DecimalOnly(mydata.Rows(0).Item("nextExpLvl").ToString, 0)

        nxtLevelBalance = nxtLevelBalance + mydata.Rows(0).Item("nextExpLvl")
        With mysql
            .setTable("tblexperience")
            .addValue(mydata.Rows(0).Item("level"), "currentLvl")
            .addValue(mydata.Rows(0).Item("imgLocation"), "rankImg")
            .addValue(mydata.Rows(0).Item("rank"), "rankName")
            .addValue(nxtLevelBalance, "nextLvl")
            .Update("UID", userID.ToString)
        End With

    End Sub
End Class