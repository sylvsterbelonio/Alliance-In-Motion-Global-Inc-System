Imports PowerNET8.myNumber.Share.Formatter

Public Class clsExperience

    Public Shared Sub getHistory(ByRef mysql As PowerNET8.mySQL.Init.SQL, ByRef list As ListBox)
        Dim mydata As DataTable = mysql.Query("SELECT * FROM tblsystem_history_mark order by dtLogMark desc limit 0,25")
        With list
            .Items.Clear()
            For i As Integer = 0 To mydata.Rows.Count - 1
                .Items.Add(mydata.Rows(i).Item("description"))
            Next
        End With
    End Sub

    Public Shared Function checkLevelExperience(ByRef mysql As PowerNET8.mySQL.Init.SQL) As Boolean
        Dim mydata As DataTable = mysql.Query("SELECT * from tblexperience where UID=" + userID.ToString)
        Dim experience As Integer = mydata.Rows(0).Item("nextLvl")
        If experience <= 0 Then
            Dim frm As New imgLevelUp
            frm.cLevel = mydata.Rows(0).Item("currentLvl")
            frm.ShowDialog()
            Return True
        End If
        Return False
    End Function

    Public Shared Sub updateExperience(ByRef mysql As PowerNET8.mySQL.Init.SQL, ByVal experienceGained As Integer, Optional ByVal category As String = "", Optional ByVal action As String = "")
        Dim mydata As DataTable = mysql.Query("select * from tblexperience where UID=" + userID.ToString)
        If mydata.Rows.Count = 0 Then
            'getting the experience
            mydata = mysql.Query("SELECT * from tblexperience_next_level_list where expID=1")
            With mysql
                .setTable("tblexperience")
                .addValue(userID.ToString, "UID")
                .addValue(mydata.Rows(0).Item("level"), "currentLvl")
                .addValue(mydata.Rows(0).Item("imgLocation"), "rankImg")
                .addValue(mydata.Rows(0).Item("rank"), "rankName")
                .addValue(mydata.Rows(0).Item("nextExpLvl"), "nextLvl")
                .Insert()
            End With
        Else
            'add additional experience
            With mysql
                .setTable("tblexperience_obtain")
                .addValue(userID.ToString, "UID")
                .addValue(category, "category")
                .addValue(action, "action")
                .addValue(experienceGained, "experience")
                .addValue(Now, "dtObtained")
                .Insert()
            End With
            'get current next level
            mydata = mysql.Query("select nextLvl from tblexperience where UID=" + userID.ToString)
            Dim nextLvl As Long = mydata.Rows(0).Item(0)
            With mysql
                .setTable("tblexperience")
                .addValue(nextLvl - experienceGained, "nextLvl")
                .Update("UID", userID.ToString)
            End With
        End If
    End Sub

    Public Shared Sub getCurrentLevelStatus(ByRef mysql As PowerNET8.mySQL.Init.SQL, ByRef lblClbl As Label, ByRef imgRank As PictureBox, ByRef lblRank As Label, ByRef lblNextLevel As Label, ByRef lblExperience As Label)
        Dim mydata As DataTable = mysql.Query("select * from tblexperience where UID=" + userID.ToString)
        If mydata.Rows.Count > 0 Then
            With mydata.Rows(0)
                lblClbl.Text = mydata.Rows(0).Item("currentLvl")
                imgRank.ImageLocation = "rank\" + mydata.Rows(0).Item("rankImg")
                lblRank.Text = mydata.Rows(0).Item("rankName")
                lblNextLevel.Text = format_DecimalOnly(mydata.Rows(0).Item("nextLvl"), 0)

                mydata = mysql.Query("SELECT SUM(experience) as 't' from tblexperience_obtain where UID=" + userID.ToString)
                lblExperience.Text = format_DecimalOnly(mydata.Rows(0).Item(0), 0)
            End With

        End If

    End Sub

    Public Shared Sub getCurrentInformation(ByRef mysql As PowerNET8.mySQL.Init.SQL, ByRef lblName As Label, ByRef lblLog As Label)
        Dim mydata As DataTable = mysql.Query("select concat(sName,', ',fName,' ',mName) as 'name' from tblpersonal_information where UID=" + userID.ToString)
        lblName.Text = mydata.Rows(0).Item("name")
        mydata = mysql.Query("SELECT max(dtLogged) as 'm' from tblsystem_user_log where UID=" + userID.ToString + " and category='account' and action='log-in'")
        Dim dt As Date = mydata.Rows(0).Item(0)
        lblLog.Text = dt.ToString("yyyy-MM-dd hh:mm tt")

    End Sub



End Class
