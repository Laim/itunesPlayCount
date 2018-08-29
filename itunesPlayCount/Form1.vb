Imports iTunesLib
Public Class Form1
    ''http://www.dreamincode.net/forums/topic/135768-moving-a-borderless-form/
    Dim itunes As New iTunesApp
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call refreshInformation()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Try
            itunes.CurrentTrack.PlayedCount = 0
            MsgBox("Play count reset to 0")
            lblValue.Text = itunes.CurrentTrack.PlayedCount
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim newCount As Integer
        newCount = InputBox("Please enter a play count")

        Try
            If IsNumeric(newCount) Then
                If newCount >= 0 Then
                    If Len(newCount) > 0 Then
                        itunes.CurrentTrack.PlayedCount = newCount
                        lblValue.Text = itunes.CurrentTrack.PlayedCount
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        Dim rn As New Random

        itunes.CurrentTrack.PlayedCount = rn.Next(100, 9999)
        lblValue.Text = itunes.CurrentTrack.PlayedCount

    End Sub

    Sub refreshInformation()
        itunes.Play()
        lblValue.Text = itunes.CurrentTrack.PlayedCount
        lblArtistInformationValue.Text = itunes.CurrentTrack.Artist
        lblSongInformationValue.Text = itunes.CurrentTrack.Name
        lblAlbumNameValue.Text = itunes.CurrentTrack.Album
        lblSongYearValue.Text = itunes.CurrentTrack.Year
        lblSongSizeValue.Text = Math.Round(itunes.CurrentTrack.Size / 1024 / 1024, 1, MidpointRounding.ToEven) & "MB"
        lblGenreValue.Text = itunes.CurrentTrack.Genre


        Dim artwork As IITArtworkCollection = itunes.CurrentTrack.Artwork()
        Dim image As IITArtwork = artwork(1)
        image.SaveArtworkToFile("C:\Users\Public\Pictures\playcount_artwork.jpg")
        picArtwork.SizeMode = PictureBoxSizeMode.AutoSize
        picArtwork.ImageLocation = "C:\Users\Public\Pictures\playcount_artwork.jpg"
        picArtwork.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call refreshInformation()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MsgBox("Program made by Laim McKenzie" + vbCrLf _
                + "There is no purpose to this program, what so ever." + vbCrLf _
                + "http://laimmckenzie.com")
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click

    End Sub
End Class
