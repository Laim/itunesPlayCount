<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.lblArtistInformation = New System.Windows.Forms.Label()
        Me.lblArtistInformationValue = New System.Windows.Forms.Label()
        Me.lblSongInformationValue = New System.Windows.Forms.Label()
        Me.lblSongInformation = New System.Windows.Forms.Label()
        Me.picArtwork = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.lblAlbumName = New System.Windows.Forms.Label()
        Me.lblAlbumNameValue = New System.Windows.Forms.Label()
        Me.lblGenreValue = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblSongSizeValue = New System.Windows.Forms.Label()
        Me.lblSongSize = New System.Windows.Forms.Label()
        Me.lblSongYearValue = New System.Windows.Forms.Label()
        Me.lblSongYear = New System.Windows.Forms.Label()
        CType(Me.picArtwork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(12, 147)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(68, 14)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "Play Count:"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(47, 196)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(124, 23)
        Me.btnSet.TabIndex = 2
        Me.btnSet.Text = "Set play count"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(265, 196)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(124, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset play count"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(84, 147)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(13, 14)
        Me.lblValue.TabIndex = 4
        Me.lblValue.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-32, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "_________________________________________________________________________________" & _
    "_"
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(12, 254)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(431, 23)
        Me.btnRandom.TabIndex = 6
        Me.btnRandom.Text = "Random Play Count (> 100 < 9999)"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'lblArtistInformation
        '
        Me.lblArtistInformation.AutoSize = True
        Me.lblArtistInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtistInformation.Location = New System.Drawing.Point(12, 12)
        Me.lblArtistInformation.Name = "lblArtistInformation"
        Me.lblArtistInformation.Size = New System.Drawing.Size(41, 14)
        Me.lblArtistInformation.TabIndex = 7
        Me.lblArtistInformation.Text = "Artist:"
        '
        'lblArtistInformationValue
        '
        Me.lblArtistInformationValue.AutoSize = True
        Me.lblArtistInformationValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtistInformationValue.Location = New System.Drawing.Point(64, 12)
        Me.lblArtistInformationValue.Name = "lblArtistInformationValue"
        Me.lblArtistInformationValue.Size = New System.Drawing.Size(33, 14)
        Me.lblArtistInformationValue.TabIndex = 8
        Me.lblArtistInformationValue.Text = "Artist"
        '
        'lblSongInformationValue
        '
        Me.lblSongInformationValue.AutoSize = True
        Me.lblSongInformationValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongInformationValue.Location = New System.Drawing.Point(64, 32)
        Me.lblSongInformationValue.Name = "lblSongInformationValue"
        Me.lblSongInformationValue.Size = New System.Drawing.Size(32, 14)
        Me.lblSongInformationValue.TabIndex = 10
        Me.lblSongInformationValue.Text = "Song"
        '
        'lblSongInformation
        '
        Me.lblSongInformation.AutoSize = True
        Me.lblSongInformation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongInformation.Location = New System.Drawing.Point(15, 32)
        Me.lblSongInformation.Name = "lblSongInformation"
        Me.lblSongInformation.Size = New System.Drawing.Size(38, 14)
        Me.lblSongInformation.TabIndex = 9
        Me.lblSongInformation.Text = "Song:"
        '
        'picArtwork
        '
        Me.picArtwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picArtwork.Location = New System.Drawing.Point(278, 12)
        Me.picArtwork.Name = "picArtwork"
        Me.picArtwork.Size = New System.Drawing.Size(162, 165)
        Me.picArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picArtwork.TabIndex = 11
        Me.picArtwork.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(47, 225)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(124, 23)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(265, 225)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(124, 23)
        Me.btnAbout.TabIndex = 13
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(12, 254)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(194, 23)
        Me.btnAll.TabIndex = 14
        Me.btnAll.Text = "Random Play Count All Songs"
        Me.btnAll.UseVisualStyleBackColor = True
        Me.btnAll.Visible = False
        '
        'lblAlbumName
        '
        Me.lblAlbumName.AutoSize = True
        Me.lblAlbumName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlbumName.Location = New System.Drawing.Point(7, 52)
        Me.lblAlbumName.Name = "lblAlbumName"
        Me.lblAlbumName.Size = New System.Drawing.Size(46, 14)
        Me.lblAlbumName.TabIndex = 15
        Me.lblAlbumName.Text = "Album:"
        '
        'lblAlbumNameValue
        '
        Me.lblAlbumNameValue.AutoSize = True
        Me.lblAlbumNameValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlbumNameValue.Location = New System.Drawing.Point(64, 52)
        Me.lblAlbumNameValue.Name = "lblAlbumNameValue"
        Me.lblAlbumNameValue.Size = New System.Drawing.Size(37, 14)
        Me.lblAlbumNameValue.TabIndex = 16
        Me.lblAlbumNameValue.Text = "Album"
        '
        'lblGenreValue
        '
        Me.lblGenreValue.AutoSize = True
        Me.lblGenreValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenreValue.Location = New System.Drawing.Point(64, 71)
        Me.lblGenreValue.Name = "lblGenreValue"
        Me.lblGenreValue.Size = New System.Drawing.Size(37, 14)
        Me.lblGenreValue.TabIndex = 17
        Me.lblGenreValue.Text = "Genre"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(9, 71)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(44, 14)
        Me.lblGenre.TabIndex = 18
        Me.lblGenre.Text = "Genre:"
        '
        'lblSongSizeValue
        '
        Me.lblSongSizeValue.AutoSize = True
        Me.lblSongSizeValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongSizeValue.Location = New System.Drawing.Point(64, 112)
        Me.lblSongSizeValue.Name = "lblSongSizeValue"
        Me.lblSongSizeValue.Size = New System.Drawing.Size(28, 14)
        Me.lblSongSizeValue.TabIndex = 22
        Me.lblSongSizeValue.Text = "Size"
        '
        'lblSongSize
        '
        Me.lblSongSize.AutoSize = True
        Me.lblSongSize.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongSize.Location = New System.Drawing.Point(20, 112)
        Me.lblSongSize.Name = "lblSongSize"
        Me.lblSongSize.Size = New System.Drawing.Size(33, 14)
        Me.lblSongSize.TabIndex = 21
        Me.lblSongSize.Text = "Size:"
        '
        'lblSongYearValue
        '
        Me.lblSongYearValue.AutoSize = True
        Me.lblSongYearValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongYearValue.Location = New System.Drawing.Point(64, 92)
        Me.lblSongYearValue.Name = "lblSongYearValue"
        Me.lblSongYearValue.Size = New System.Drawing.Size(30, 14)
        Me.lblSongYearValue.TabIndex = 20
        Me.lblSongYearValue.Text = "Year"
        '
        'lblSongYear
        '
        Me.lblSongYear.AutoSize = True
        Me.lblSongYear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongYear.Location = New System.Drawing.Point(20, 92)
        Me.lblSongYear.Name = "lblSongYear"
        Me.lblSongYear.Size = New System.Drawing.Size(34, 14)
        Me.lblSongYear.TabIndex = 19
        Me.lblSongYear.Text = "Year:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 289)
        Me.Controls.Add(Me.lblSongSizeValue)
        Me.Controls.Add(Me.lblSongSize)
        Me.Controls.Add(Me.lblSongYearValue)
        Me.Controls.Add(Me.lblSongYear)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblGenreValue)
        Me.Controls.Add(Me.lblAlbumNameValue)
        Me.Controls.Add(Me.lblAlbumName)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.picArtwork)
        Me.Controls.Add(Me.lblSongInformationValue)
        Me.Controls.Add(Me.lblSongInformation)
        Me.Controls.Add(Me.lblArtistInformationValue)
        Me.Controls.Add(Me.lblArtistInformation)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.lblCount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "iTunes Play Count Changer"
        CType(Me.picArtwork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRandom As System.Windows.Forms.Button
    Friend WithEvents lblArtistInformation As System.Windows.Forms.Label
    Friend WithEvents lblArtistInformationValue As System.Windows.Forms.Label
    Friend WithEvents lblSongInformationValue As System.Windows.Forms.Label
    Friend WithEvents lblSongInformation As System.Windows.Forms.Label
    Friend WithEvents picArtwork As System.Windows.Forms.PictureBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents lblAlbumName As System.Windows.Forms.Label
    Friend WithEvents lblAlbumNameValue As System.Windows.Forms.Label
    Friend WithEvents lblGenreValue As System.Windows.Forms.Label
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents lblSongSizeValue As System.Windows.Forms.Label
    Friend WithEvents lblSongSize As System.Windows.Forms.Label
    Friend WithEvents lblSongYearValue As System.Windows.Forms.Label
    Friend WithEvents lblSongYear As System.Windows.Forms.Label

End Class
