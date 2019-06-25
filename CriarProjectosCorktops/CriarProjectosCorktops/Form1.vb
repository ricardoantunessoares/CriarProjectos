Imports System.IO

Public Class Form1

    Public FilePath As String
    Public MachineNumber As Integer

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub EncerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button_LimparSJF_Click(sender As Object, e As EventArgs) Handles Button_LimparSJF.Click
        TextBox_SJF.Text = String.Empty
        PictureBox_PicturePNG.Image = PictureBox_PicturePNG.InitialImage
        PictureBox_PicturePNG.ImageLocation = String.Empty
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
        End If
    End Sub

    Private Sub NotifyIcon_CriarProjectoCorkTops_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon_CriarProjectoCorkTops.DoubleClick
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon_CriarProjectoCorkTops.BalloonTipText = "Inicie criação de projectos."
        NotifyIcon_CriarProjectoCorkTops.BalloonTipTitle = "CriarProjecto"
        NotifyIcon_CriarProjectoCorkTops.Visible = True
        NotifyIcon_CriarProjectoCorkTops.ShowBalloonTip(0)

        LoadParameters()
        SaveParameters()
        LayoutPage(0)

    End Sub

    Private Sub NovoProjectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoProjectoToolStripMenuItem.Click
        LayoutPage(0)
    End Sub

    Private Sub Button_AbrirSJF_Click(sender As Object, e As EventArgs) Handles Button_AbrirSJF.Click
        OpenFileDialogImageSJF_FileA.Filter = "Scaps files (*.sjf)|*.sjf"
        OpenFileDialogImageSJF_FileA.ShowDialog()
    End Sub

    Private Sub OpenFileDialogImageSJF_FileA_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialogImageSJF_FileA.FileOk
        TextBox_SJF.Text = OpenFileDialogImageSJF_FileA.FileName

        Try
            Dim filePath As String
            filePath = OpenFileDialogImageSJF_FileA.FileName

            Dim fileDirectory As String
            fileDirectory = Path.GetDirectoryName(filePath)

            Dim fileName As String
            fileName = Path.GetFileNameWithoutExtension(filePath)

            Dim filePicture As String
            filePicture = fileDirectory + "\" + fileName + ".png"

            If System.IO.File.Exists(filePicture) Then
                'The file exists
                PictureBox_PicturePNG.ImageLocation = filePicture
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button_CancelarMaq1_Click(sender As Object, e As EventArgs) Handles Button_Cancelar_Maq1.Click
        LayoutPage(0)
    End Sub

    Private Sub Button_ApagarProjecto_Click(sender As Object, e As EventArgs) Handles Button_ApagarProjecto.Click
        LayoutPage(0)
    End Sub

    Private Sub Máquina1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Máquina1ToolStripMenuItem.Click
        LayoutPage(1)
    End Sub

    Private Sub Máquina2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Máquina2ToolStripMenuItem.Click
        LayoutPage(2)
    End Sub

    Private Sub Máquina3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Máquina3ToolStripMenuItem.Click
        LayoutPage(3)
    End Sub

    Private Sub Button_AlterarMaq1_Click(sender As Object, e As EventArgs) Handles Button_Alterar_Maq1.Click
        My.Settings.DxL_Maq1 = TextBox1_DxL.Text
        My.Settings.DxR_Maq1 = TextBox1_DxR.Text
        My.Settings.DyL_Maq1 = TextBox1_DyL.Text
        My.Settings.DyR_Maq1 = TextBox1_DyR.Text
        My.Settings.Diameter_Maq1 = TextBox1_Diameter.Text
        My.Settings.Lenght_Maq1 = TextBox1_Lenght.Text
        My.Settings.Focus_Maq1 = TextBox1_Focus.Text
        My.Settings.OffsetX_Maq1 = TextBox1_OffsetX.Text
        My.Settings.OffsetY_Maq1 = TextBox1_OffsetY.Text
        My.Settings.GainX_Maq1 = TextBox1_GainX.Text
        My.Settings.GainY_Maq1 = TextBox1_GainY.Text
        My.Settings.Rotation_Maq1 = TextBox1_Rotation.Text
        My.Settings.PathMaq1 = TextBox1_Path.Text
        My.Settings.Save()
        My.Settings.Reload()

        WriteFileParameters()

        MsgBox("Parâmetros da máquina 1 alterados com sucesso.", MsgBoxStyle.Information)
    End Sub

    Private Sub Button_Alterar_Maq2_Click(sender As Object, e As EventArgs) Handles Button_Alterar_Maq2.Click
        My.Settings.DxL_Maq2 = TextBox2_DxL.Text
        My.Settings.DxR_Maq2 = TextBox2_DxR.Text
        My.Settings.DyL_Maq2 = TextBox2_DyL.Text
        My.Settings.DyR_Maq2 = TextBox2_DyR.Text
        My.Settings.Diameter_Maq2 = TextBox2_Diameter.Text
        My.Settings.Lenght_Maq2 = TextBox2_Lenght.Text
        My.Settings.Focus_Maq2 = TextBox2_Focus.Text
        My.Settings.OffsetX_Maq2 = TextBox2_OffsetX.Text
        My.Settings.OffsetY_Maq2 = TextBox2_OffsetY.Text
        My.Settings.GainX_Maq2 = TextBox2_GainX.Text
        My.Settings.GainY_Maq2 = TextBox2_GainY.Text
        My.Settings.Rotation_Maq2 = TextBox2_Rotation.Text
        My.Settings.PathMaq2 = TextBox2_Path.Text
        My.Settings.Save()
        My.Settings.Reload()

        WriteFileParameters()

        MsgBox("Parâmetros da máquina 2 alterados com sucesso.", MsgBoxStyle.Information)
    End Sub

    Private Sub Button_Alterar_Maq3_Click(sender As Object, e As EventArgs) Handles Button_Alterar_Maq3.Click
        My.Settings.DxL_Maq3 = TextBox3_DxL.Text
        My.Settings.DxR_Maq3 = TextBox3_DxR.Text
        My.Settings.DyL_Maq3 = TextBox3_DyL.Text
        My.Settings.DyR_Maq3 = TextBox3_DyR.Text
        My.Settings.Diameter_Maq3 = TextBox3_Diameter.Text
        My.Settings.Lenght_Maq3 = TextBox3_Lenght.Text
        My.Settings.Focus_Maq3 = TextBox3_Focus.Text
        My.Settings.OffsetX_Maq3 = TextBox3_OffsetX.Text
        My.Settings.OffsetY_Maq3 = TextBox3_OffsetY.Text
        My.Settings.GainX_Maq3 = TextBox3_GainX.Text
        My.Settings.GainY_Maq3 = TextBox3_GainY.Text
        My.Settings.Rotation_Maq3 = TextBox3_Rotation.Text
        My.Settings.PathMaq3 = TextBox3_Path.Text
        My.Settings.Save()
        My.Settings.Reload()

        WriteFileParameters()

        MsgBox("Parâmetros da máquina 3 alterados com sucesso.", MsgBoxStyle.Information)
    End Sub

    Private Sub Button_Cancelar_Maq2_Click(sender As Object, e As EventArgs) Handles Button_Cancelar_Maq2.Click
        LayoutPage(0)
    End Sub

    Private Sub Button_Cancelar_Maq3_Click(sender As Object, e As EventArgs) Handles Button_Cancelar_Maq3.Click
        LayoutPage(0)
    End Sub

    Private Sub Button_EnviarProjecto_Click(sender As Object, e As EventArgs) Handles Button_EnviarProjecto.Click
        Try
            Dim newFileDirectory As String = String.Empty
            Dim fileDirectory As String = String.Empty
            Dim fileName As String = String.Empty
            Dim filePicture As String = String.Empty
            Dim Msg, Style, Title, Response

            If TextBox_SJF.Text = String.Empty Then
                Throw New System.Exception("Impossivel criar projecto. Projecto sem ficheiro de desenho *.sjf")
            Else
                Try
                    FilePath = TextBox_SJF.Text
                    MachineNumber = ComboBox_Maquina.SelectedIndex

                    fileName = Path.GetFileNameWithoutExtension(FilePath)
                    fileDirectory = Path.GetDirectoryName(FilePath)

                    newFileDirectory = fileDirectory + "\" + fileName

                    If My.Computer.FileSystem.DirectoryExists(newFileDirectory) = False Then
                        My.Computer.FileSystem.CreateDirectory(newFileDirectory)
                    Else

                        Msg = "Pasta '" + Path.GetFileName(fileName) + "' já existe na directoria:" & vbNewLine
                        Msg = Msg + fileDirectory & vbNewLine
                        Msg = Msg + "Pretende substituir?"
                        Style = vbYesNo + vbInformation
                        Title = "Aviso"    ' Define title.

                        ' Display message.
                        Response = MsgBox(Msg, Style, Title)
                        If Response = vbNo Then
                            '"Ficheiro " + Path.GetFileNameWithoutExtension(FileToSaveAs) + " já existe."
                            Throw New System.Exception("")
                        End If

                    End If
                Catch ex As Exception
                    If ex.Message = "" Then
                        Throw New System.Exception("")
                    Else
                        Throw New System.Exception("Impossivel criar pasta projecto. Erro: " + ex.Message)
                    End If
                End Try
            End If

            Dim strNewPathPicturePNG As String = String.Empty
            Dim strPathPicturePNG As String = String.Empty
            Dim strNamePicturePNG As String = String.Empty
            Dim PathImageToHead1_PNG As String = String.Empty
            Dim PathImageToHead2_PNG As String = String.Empty

            Try
                Try
                    filePicture = newFileDirectory + "\" + fileName + ".png"
                Catch ex As Exception

                End Try

                If PictureBox_PicturePNG.ImageLocation <> String.Empty Then
                    strPathPicturePNG = PictureBox_PicturePNG.ImageLocation
                    strNamePicturePNG = My.Computer.FileSystem.GetName(strPathPicturePNG).ToString
                    PathImageToHead1_PNG = newFileDirectory + "\" + "ImageToHead1.png"
                    PathImageToHead2_PNG = newFileDirectory + "\" + "ImageToHead2.png"

                    My.Computer.FileSystem.CopyFile(FilePath, newFileDirectory + "\" + Path.GetFileName(FilePath), Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                    My.Computer.FileSystem.CopyFile(strPathPicturePNG, newFileDirectory + "\" + Path.GetFileName(strPathPicturePNG), Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                    My.Computer.FileSystem.CopyFile(strPathPicturePNG, PathImageToHead1_PNG, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                    My.Computer.FileSystem.CopyFile(strPathPicturePNG, PathImageToHead2_PNG, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)

                End If

                Dim FileToSaveAs As String = newFileDirectory + "\" + fileName + ".cfgL"

                If My.Computer.FileSystem.FileExists(FileToSaveAs) = True Then
                    Msg = "Ficheiro " + Path.GetFileName(FileToSaveAs) + " já existe! Pretende substituir?"
                    Style = vbYesNo + vbInformation
                    Title = "Aviso"    ' Define title.

                    ' Display message.
                    Response = MsgBox(Msg, Style, Title)
                    If Response = vbNo Then
                        '"Ficheiro " + Path.GetFileNameWithoutExtension(FileToSaveAs) + " já existe."
                        Throw New System.Exception("")
                    End If
                End If

                Dim objwriter As New System.IO.StreamWriter(FileToSaveAs)

                Try
                    ' List configurations to save
                    objwriter.WriteLine("PathPictureA_SJF: " + "C:\Projects\" + fileName + "\" + Path.GetFileName(FilePath))
                    objwriter.WriteLine("PathPictureA_PNG: " + "C:\Projects\" + fileName + "\" + Path.GetFileName(strPathPicturePNG))
                    objwriter.WriteLine("PathImageToHead1_PNG: " + "C:\Projects\" + fileName + "\" + Path.GetFileName(PathImageToHead1_PNG))
                    objwriter.WriteLine("PathImageToHead2_PNG: " + "C:\Projects\" + fileName + "\" + Path.GetFileName(PathImageToHead2_PNG))
                    objwriter.WriteLine("TypeQualityEngrave: 1")

                    Select Case MachineNumber
                        Case 0
                            objwriter.WriteLine("DxL: " + My.Settings.DxL_Maq1.ToString)
                            objwriter.WriteLine("DxR: " + My.Settings.DxR_Maq1.ToString)
                            objwriter.WriteLine("DyL: " + My.Settings.DyL_Maq1.ToString)
                            objwriter.WriteLine("DyR: " + My.Settings.DyR_Maq1.ToString)

                            objwriter.WriteLine("Diameter: " + My.Settings.Diameter_Maq1.ToString)
                            objwriter.WriteLine("Lenght: " + My.Settings.Lenght_Maq1.ToString)
                            objwriter.WriteLine("Focus: ")

                            objwriter.WriteLine("OffsetX: " + My.Settings.OffsetX_Maq1.ToString)
                            objwriter.WriteLine("OffsetY: " + My.Settings.OffsetY_Maq1.ToString)
                            objwriter.WriteLine("GainX: " + My.Settings.GainX_Maq1.ToString)
                            objwriter.WriteLine("GainY: " + My.Settings.GainY_Maq1.ToString)
                            objwriter.WriteLine("Rotation: " + My.Settings.Rotation_Maq1.ToString)

                            objwriter.WriteLine("GainPicture_SJF: 1.000")

                            objwriter.WriteLine("CounterMark: ")
                            objwriter.WriteLine("MarkCountToFinish: ")
                            objwriter.WriteLine("CheckBoxHEAD2: ")
                            objwriter.WriteLine("PartialCounter: ")
                        Case 1
                            objwriter.WriteLine("DxL: " + My.Settings.DxL_Maq2.ToString)
                            objwriter.WriteLine("DxR: " + My.Settings.DxR_Maq2.ToString)
                            objwriter.WriteLine("DyL: " + My.Settings.DyL_Maq2.ToString)
                            objwriter.WriteLine("DyR: " + My.Settings.DyR_Maq2.ToString)

                            objwriter.WriteLine("Diameter: " + My.Settings.Diameter_Maq2.ToString)
                            objwriter.WriteLine("Lenght: " + My.Settings.Lenght_Maq2.ToString)
                            objwriter.WriteLine("Focus: ")

                            objwriter.WriteLine("OffsetX: " + My.Settings.OffsetX_Maq2.ToString)
                            objwriter.WriteLine("OffsetY: " + My.Settings.OffsetY_Maq2.ToString)
                            objwriter.WriteLine("GainX: " + My.Settings.GainX_Maq2.ToString)
                            objwriter.WriteLine("GainY: " + My.Settings.GainY_Maq2.ToString)
                            objwriter.WriteLine("Rotation: " + My.Settings.Rotation_Maq2.ToString)

                            objwriter.WriteLine("GainPicture_SJF: 1.000")

                            objwriter.WriteLine("CounterMark: ")
                            objwriter.WriteLine("MarkCountToFinish: ")
                            objwriter.WriteLine("CheckBoxHEAD2: ")
                            objwriter.WriteLine("PartialCounter: ")
                        Case 2
                            objwriter.WriteLine("DxL: " + My.Settings.DxL_Maq3.ToString)
                            objwriter.WriteLine("DxR: " + My.Settings.DxR_Maq3.ToString)
                            objwriter.WriteLine("DyL: " + My.Settings.DyL_Maq3.ToString)
                            objwriter.WriteLine("DyR: " + My.Settings.DyR_Maq3.ToString)

                            objwriter.WriteLine("Diameter: " + My.Settings.Diameter_Maq3.ToString)
                            objwriter.WriteLine("Lenght: " + My.Settings.Lenght_Maq3.ToString)
                            objwriter.WriteLine("Focus: ")

                            objwriter.WriteLine("OffsetX: " + My.Settings.OffsetX_Maq3.ToString)
                            objwriter.WriteLine("OffsetY: " + My.Settings.OffsetY_Maq3.ToString)
                            objwriter.WriteLine("GainX: " + My.Settings.GainX_Maq3.ToString)
                            objwriter.WriteLine("GainY: " + My.Settings.GainY_Maq3.ToString)
                            objwriter.WriteLine("Rotation: " + My.Settings.Rotation_Maq3.ToString)

                            objwriter.WriteLine("GainPicture_SJF: 1.000")

                            objwriter.WriteLine("CounterMark: ")
                            objwriter.WriteLine("MarkCountToFinish: ")
                            objwriter.WriteLine("CheckBoxHEAD2: ")
                            objwriter.WriteLine("PartialCounter: ")
                        Case Else
                            Throw New System.Exception("Impossivel criar projecto. Máquina não identificada.")
                    End Select

                    ' Close file
                    objwriter.Close()
                Catch ex As Exception
                    ' Close file
                    objwriter.Close()
                    Throw New System.Exception(ex.Message)
                End Try

                Msg = "Projecto '" + Path.GetFileNameWithoutExtension(FileToSaveAs) + "' foi criado com sucesso na directoria:" & vbNewLine
                Msg = Msg + fileDirectory & vbNewLine
                Msg = Msg + "Pretende enviar projecto para a " + ComboBox_Maquina.SelectedItem + " ?"
                Style = vbYesNo + vbInformation
                Title = "Projecto Criado"
                Response = MsgBox(Msg, Style, Title)

                '++++++++++++++++++++++++++++
                ' Processo de envio da pasta
                '++++++++++++++++++++++++++++

                Try
                    If Response = vbYes Then
                        Dim destinationDirectory As String
                        Select Case MachineNumber
                            Case 0
                                destinationDirectory = My.Settings.PathMaq1
                            Case 1
                                destinationDirectory = My.Settings.PathMaq2
                            Case 2
                                destinationDirectory = My.Settings.PathMaq3
                            Case Else
                                Throw New System.Exception("Abortado o envio do projecto! Máquina não identificada.")
                        End Select

                        Dim Folder As New IO.DirectoryInfo(destinationDirectory + "/" + fileName)
                        If IO.Directory.Exists(Folder.FullName) Then
                            Msg = "Projecto '" + Path.GetFileNameWithoutExtension(FileToSaveAs) + "' já existe na " + ComboBox_Maquina.SelectedItem & vbNewLine
                            Msg = Msg + "Pretende substituir no destino?"
                            Style = vbYesNo + vbInformation
                            Title = "Projecto Existente"
                            Response = MsgBox(Msg, Style, Title)

                            If Response = vbYes Then
                                IO.Directory.Delete(Folder.FullName, True)
                                IO.Directory.CreateDirectory(Folder.FullName)

                                Dim arrStr As String() = {}

                                Dim tmp As String = newFileDirectory + "\"

                                arrStr = System.IO.Directory.GetFiles(tmp)

                                For i As Integer = 0 To arrStr.Length - 1

                                    arrStr(i) = arrStr(i).Replace(tmp, "")

                                Next

                                For i As Integer = 0 To arrStr.Length - 1

                                    System.IO.File.Copy(newFileDirectory + "\" & arrStr(i), Folder.FullName + "\" & arrStr(i))

                                Next

                                Msg = "Projecto '" + Path.GetFileNameWithoutExtension(FileToSaveAs) + "' foi substituido com sucesso na directoria:" & vbNewLine
                                Msg = Msg + destinationDirectory + "\" + fileName
                                Style = vbOK + vbInformation
                                Title = "Transferência de Projecto" + Path.GetFileNameWithoutExtension(FileToSaveAs)
                                MsgBox(Msg, Style, Title)
                            End If
                        Else
                            IO.Directory.CreateDirectory(Folder.FullName)
                            Dim arrStr As String() = {}

                            Dim tmp As String = newFileDirectory + "\"

                            arrStr = System.IO.Directory.GetFiles(tmp)

                            For i As Integer = 0 To arrStr.Length - 1

                                arrStr(i) = arrStr(i).Replace(tmp, "")

                            Next

                            For i As Integer = 0 To arrStr.Length - 1

                                System.IO.File.Copy(newFileDirectory + "\" & arrStr(i), Folder.FullName + "\" & arrStr(i))

                            Next


                            Msg = "Projecto '" + Path.GetFileNameWithoutExtension(FileToSaveAs) + "' foi enviado com sucesso para a directoria:" & vbNewLine
                            Msg = Msg + destinationDirectory
                            Style = vbOK + vbInformation
                            Title = "Transferência de Projecto" + Path.GetFileNameWithoutExtension(FileToSaveAs)
                            MsgBox(Msg, Style, Title)
                        End If

                        IO.Directory.Delete(newFileDirectory, True)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try

                LayoutPage(0)
            Catch ex As Exception
                If Not ex.Message = "" Then
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End If
            End Try

        Catch ex As Exception
            If ex.Message = "" Then
                MsgBox("Abortada criação de projecto. " & ex.Message, MsgBoxStyle.Information)
            Else
                MsgBox("Falha ao criar projecto. " & ex.Message, MsgBoxStyle.Critical)
            End If
        End Try
    End Sub

    Private Sub LayoutPage(ByVal layoutType As Integer)

        Select Case layoutType
            Case 1
                GroupBox_Maquina1.Visible = True
                GroupBox_Maquina2.Visible = False
                GroupBox_Maquina3.Visible = False
                GroupBox_NovoProjecto.Visible = False

                TextBox1_DxL.Text = My.Settings.DxL_Maq1
                TextBox1_DxR.Text = My.Settings.DxR_Maq1
                TextBox1_DyL.Text = My.Settings.DyL_Maq1
                TextBox1_DyR.Text = My.Settings.DyR_Maq1
                TextBox1_Diameter.Text = My.Settings.Diameter_Maq1
                TextBox1_Lenght.Text = My.Settings.Lenght_Maq1
                TextBox1_Focus.Text = My.Settings.Focus_Maq1
                TextBox1_OffsetX.Text = My.Settings.OffsetX_Maq1
                TextBox1_OffsetY.Text = My.Settings.OffsetY_Maq1
                TextBox1_GainX.Text = My.Settings.GainX_Maq1
                TextBox1_GainY.Text = My.Settings.GainY_Maq1
                TextBox1_Rotation.Text = My.Settings.Rotation_Maq1
                TextBox1_Path.Text = My.Settings.PathMaq1
            Case 2
                GroupBox_Maquina1.Visible = False
                GroupBox_Maquina2.Visible = True
                GroupBox_Maquina3.Visible = False
                GroupBox_NovoProjecto.Visible = False

                TextBox2_DxL.Text = My.Settings.DxL_Maq2
                TextBox2_DxR.Text = My.Settings.DxR_Maq2
                TextBox2_DyL.Text = My.Settings.DyL_Maq2
                TextBox2_DyR.Text = My.Settings.DyR_Maq2
                TextBox2_Diameter.Text = My.Settings.Diameter_Maq2
                TextBox2_Lenght.Text = My.Settings.Lenght_Maq2
                TextBox2_Focus.Text = My.Settings.Focus_Maq2
                TextBox2_OffsetX.Text = My.Settings.OffsetX_Maq2
                TextBox2_OffsetY.Text = My.Settings.OffsetY_Maq2
                TextBox2_GainX.Text = My.Settings.GainX_Maq2
                TextBox2_GainY.Text = My.Settings.GainY_Maq2
                TextBox2_Rotation.Text = My.Settings.Rotation_Maq2
                TextBox2_Path.Text = My.Settings.PathMaq2
            Case 3
                GroupBox_Maquina1.Visible = False
                GroupBox_Maquina2.Visible = False
                GroupBox_Maquina3.Visible = True
                GroupBox_NovoProjecto.Visible = False

                TextBox3_DxL.Text = My.Settings.DxL_Maq3
                TextBox3_DxR.Text = My.Settings.DxR_Maq3
                TextBox3_DyL.Text = My.Settings.DyL_Maq3
                TextBox3_DyR.Text = My.Settings.DyR_Maq3
                TextBox3_Diameter.Text = My.Settings.Diameter_Maq3
                TextBox3_Lenght.Text = My.Settings.Lenght_Maq3
                TextBox3_Focus.Text = My.Settings.Focus_Maq3
                TextBox3_OffsetX.Text = My.Settings.OffsetX_Maq3
                TextBox3_OffsetY.Text = My.Settings.OffsetY_Maq3
                TextBox3_GainX.Text = My.Settings.GainX_Maq3
                TextBox3_GainY.Text = My.Settings.GainY_Maq3
                TextBox3_Rotation.Text = My.Settings.Rotation_Maq3
                TextBox3_Path.Text = My.Settings.PathMaq3
            Case Else
                GroupBox_Maquina1.Visible = False
                GroupBox_Maquina2.Visible = False
                GroupBox_Maquina3.Visible = False
                GroupBox_NovoProjecto.Visible = True

                ComboBox_Maquina.SelectedItem = "Máquina 1"
                TextBox_SJF.Text = String.Empty
                PictureBox_PicturePNG.Image = PictureBox_PicturePNG.InitialImage
                PictureBox_PicturePNG.ImageLocation = String.Empty
        End Select

    End Sub

    Private Sub WriteFileParameters()
        Try
            Dim pathSettings As String = Directory.GetCurrentDirectory() + "\settings.ini"
            Dim objwriter As New System.IO.StreamWriter(pathSettings)

            Try


                ' List configurations to save
#Region "Maq1"
                objwriter.WriteLine("DxL_Maq1: " + My.Settings.DxL_Maq1)
                objwriter.WriteLine("DxR_Maq1: " + My.Settings.DxR_Maq1)
                objwriter.WriteLine("DyL_Maq1: " + My.Settings.DyL_Maq1)
                objwriter.WriteLine("DyR_Maq1: " + My.Settings.DyR_Maq1)
                objwriter.WriteLine("Diameter_Maq1: " + My.Settings.Diameter_Maq1)
                objwriter.WriteLine("Lenght_Maq1: " + My.Settings.Lenght_Maq1)
                objwriter.WriteLine("Focus_Maq1: " + My.Settings.Focus_Maq1)
                objwriter.WriteLine("OffsetX_Maq1: " + My.Settings.OffsetX_Maq1)
                objwriter.WriteLine("OffsetY_Maq1: " + My.Settings.OffsetY_Maq1)
                objwriter.WriteLine("GainX_Maq1: " + My.Settings.GainX_Maq1)
                objwriter.WriteLine("GainY_Maq1: " + My.Settings.GainY_Maq1)
                objwriter.WriteLine("Rotation_Maq1: " + My.Settings.Rotation_Maq1)
                objwriter.WriteLine("PathMaq1: " + My.Settings.PathMaq1)
#End Region

#Region "Maq2"
                objwriter.WriteLine("DxL_Maq2: " + My.Settings.DxL_Maq2)
                objwriter.WriteLine("DxR_Maq2: " + My.Settings.DxR_Maq2)
                objwriter.WriteLine("DyL_Maq2: " + My.Settings.DyL_Maq2)
                objwriter.WriteLine("DyR_Maq2: " + My.Settings.DyR_Maq2)
                objwriter.WriteLine("Diameter_Maq2: " + My.Settings.Diameter_Maq2)
                objwriter.WriteLine("Lenght_Maq2: " + My.Settings.Lenght_Maq2)
                objwriter.WriteLine("Focus_Maq2: " + My.Settings.Focus_Maq2)
                objwriter.WriteLine("OffsetX_Maq2: " + My.Settings.OffsetX_Maq2)
                objwriter.WriteLine("OffsetY_Maq2: " + My.Settings.OffsetY_Maq2)
                objwriter.WriteLine("GainX_Maq2: " + My.Settings.GainX_Maq2)
                objwriter.WriteLine("GainY_Maq2: " + My.Settings.GainY_Maq2)
                objwriter.WriteLine("Rotation_Maq2: " + My.Settings.Rotation_Maq2)
                objwriter.WriteLine("PathMaq2: " + My.Settings.PathMaq2)
#End Region

#Region "Maq3"
                objwriter.WriteLine("DxL_Maq3: " + My.Settings.DxL_Maq3)
                objwriter.WriteLine("DxR_Maq3: " + My.Settings.DxR_Maq3)
                objwriter.WriteLine("DyL_Maq3: " + My.Settings.DyL_Maq3)
                objwriter.WriteLine("DyR_Maq3: " + My.Settings.DyR_Maq3)
                objwriter.WriteLine("Diameter_Maq3: " + My.Settings.Diameter_Maq3)
                objwriter.WriteLine("Lenght_Maq3: " + My.Settings.Lenght_Maq3)
                objwriter.WriteLine("Focus_Maq3: " + My.Settings.Focus_Maq3)
                objwriter.WriteLine("OffsetX_Maq3: " + My.Settings.OffsetX_Maq3)
                objwriter.WriteLine("OffsetY_Maq3: " + My.Settings.OffsetY_Maq3)
                objwriter.WriteLine("GainX_Maq3: " + My.Settings.GainX_Maq3)
                objwriter.WriteLine("GainY_Maq3: " + My.Settings.GainY_Maq3)
                objwriter.WriteLine("Rotation_Maq3: " + My.Settings.Rotation_Maq3)
                objwriter.WriteLine("PathMaq3: " + My.Settings.PathMaq3)
#End Region

                ' Close file
                objwriter.Close()

            Catch ex As Exception
                ' Close file
                objwriter.Close()
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ReadFileParameters()
        Dim straux As String
        Dim pathSettings As String = Directory.GetCurrentDirectory() + "\settings.ini"

        Try

#Region "Maq1"
            straux = GetItem(pathSettings, "DxL_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_DxL.Text = straux
            End If

            straux = GetItem(pathSettings, "DxR_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_DxR.Text = straux
            End If

            straux = GetItem(pathSettings, "DyL_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_DyL.Text = straux
            End If

            straux = GetItem(pathSettings, "DyR_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_DyR.Text = straux
            End If

            straux = GetItem(pathSettings, "Diameter_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_Diameter.Text = straux
            End If

            straux = GetItem(pathSettings, "Lenght_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_Lenght.Text = straux
            End If

            straux = GetItem(pathSettings, "Focus_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_Focus.Text = straux
            End If

            straux = GetItem(pathSettings, "OffsetX_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_OffsetX.Text = straux
            End If

            straux = GetItem(pathSettings, "OffsetY_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_OffsetY.Text = straux
            End If

            straux = GetItem(pathSettings, "GainX_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_GainX.Text = straux
            End If

            straux = GetItem(pathSettings, "GainY_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_GainY.Text = straux
            End If

            straux = GetItem(pathSettings, "Rotation_Maq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_Rotation.Text = straux
            End If

            straux = GetItem(pathSettings, "PathMaq1")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox1_Path.Text = straux
            End If
#End Region

#Region "Maq2"
            straux = GetItem(pathSettings, "DxL_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_DxL.Text = straux
            End If

            straux = GetItem(pathSettings, "DxR_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_DxR.Text = straux
            End If

            straux = GetItem(pathSettings, "DyL_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_DyL.Text = straux
            End If

            straux = GetItem(pathSettings, "DyR_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_DyR.Text = straux
            End If

            straux = GetItem(pathSettings, "Diameter_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_Diameter.Text = straux
            End If

            straux = GetItem(pathSettings, "Lenght_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_Lenght.Text = straux
            End If

            straux = GetItem(pathSettings, "Focus_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_Focus.Text = straux
            End If

            straux = GetItem(pathSettings, "OffsetX_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_OffsetX.Text = straux
            End If

            straux = GetItem(pathSettings, "OffsetY_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_OffsetY.Text = straux
            End If

            straux = GetItem(pathSettings, "GainX_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_GainX.Text = straux
            End If

            straux = GetItem(pathSettings, "GainY_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_GainY.Text = straux
            End If

            straux = GetItem(pathSettings, "Rotation_Maq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_Rotation.Text = straux
            End If

            straux = GetItem(pathSettings, "PathMaq2")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox2_Path.Text = straux
            End If
#End Region

#Region "Maq3"
            straux = GetItem(pathSettings, "DxL_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_DxL.Text = straux
            End If

            straux = GetItem(pathSettings, "DxR_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_DxR.Text = straux
            End If

            straux = GetItem(pathSettings, "DyL_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_DyL.Text = straux
            End If

            straux = GetItem(pathSettings, "DyR_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_DyR.Text = straux
            End If

            straux = GetItem(pathSettings, "Diameter_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_Diameter.Text = straux
            End If

            straux = GetItem(pathSettings, "Lenght_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_Lenght.Text = straux
            End If

            straux = GetItem(pathSettings, "Focus_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_Focus.Text = straux
            End If

            straux = GetItem(pathSettings, "OffsetX_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_OffsetX.Text = straux
            End If

            straux = GetItem(pathSettings, "OffsetY_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_OffsetY.Text = straux
            End If

            straux = GetItem(pathSettings, "GainX_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_GainX.Text = straux
            End If

            straux = GetItem(pathSettings, "GainY_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_GainY.Text = straux
            End If

            straux = GetItem(pathSettings, "Rotation_Maq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_Rotation.Text = straux
            End If

            straux = GetItem(pathSettings, "PathMaq3")
            If Not String.IsNullOrEmpty(straux) Then
                TextBox3_Path.Text = straux
            End If
#End Region
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadParameters()

        Dim pathSettings As String = Directory.GetCurrentDirectory() + "\settings.ini"

        If My.Computer.FileSystem.FileExists(pathSettings) Then
            ReadFileParameters()
        Else
            WriteFileParameters()
        End If
    End Sub

    Private Sub SaveParameters()
        My.Settings.DxL_Maq1 = TextBox1_DxL.Text
        My.Settings.DxR_Maq1 = TextBox1_DxR.Text
        My.Settings.DyL_Maq1 = TextBox1_DyL.Text
        My.Settings.DyR_Maq1 = TextBox1_DyR.Text
        My.Settings.Diameter_Maq1 = TextBox1_Diameter.Text
        My.Settings.Lenght_Maq1 = TextBox1_Lenght.Text
        My.Settings.Focus_Maq1 = TextBox1_Focus.Text
        My.Settings.OffsetX_Maq1 = TextBox1_OffsetX.Text
        My.Settings.OffsetY_Maq1 = TextBox1_OffsetY.Text
        My.Settings.GainX_Maq1 = TextBox1_GainX.Text
        My.Settings.GainY_Maq1 = TextBox1_GainY.Text
        My.Settings.Rotation_Maq1 = TextBox1_Rotation.Text
        My.Settings.PathMaq1 = TextBox1_Path.Text

        My.Settings.DxL_Maq2 = TextBox2_DxL.Text
        My.Settings.DxR_Maq2 = TextBox2_DxR.Text
        My.Settings.DyL_Maq2 = TextBox2_DyL.Text
        My.Settings.DyR_Maq2 = TextBox2_DyR.Text
        My.Settings.Diameter_Maq2 = TextBox2_Diameter.Text
        My.Settings.Lenght_Maq2 = TextBox2_Lenght.Text
        My.Settings.Focus_Maq2 = TextBox2_Focus.Text
        My.Settings.OffsetX_Maq2 = TextBox2_OffsetX.Text
        My.Settings.OffsetY_Maq2 = TextBox2_OffsetY.Text
        My.Settings.GainX_Maq2 = TextBox2_GainX.Text
        My.Settings.GainY_Maq2 = TextBox2_GainY.Text
        My.Settings.Rotation_Maq2 = TextBox2_Rotation.Text
        My.Settings.PathMaq2 = TextBox2_Path.Text

        My.Settings.DxL_Maq3 = TextBox3_DxL.Text
        My.Settings.DxR_Maq3 = TextBox3_DxR.Text
        My.Settings.DyL_Maq3 = TextBox3_DyL.Text
        My.Settings.DyR_Maq3 = TextBox3_DyR.Text
        My.Settings.Diameter_Maq3 = TextBox3_Diameter.Text
        My.Settings.Lenght_Maq3 = TextBox3_Lenght.Text
        My.Settings.Focus_Maq3 = TextBox3_Focus.Text
        My.Settings.OffsetX_Maq3 = TextBox3_OffsetX.Text
        My.Settings.OffsetY_Maq3 = TextBox3_OffsetY.Text
        My.Settings.GainX_Maq3 = TextBox3_GainX.Text
        My.Settings.GainY_Maq3 = TextBox3_GainY.Text
        My.Settings.Rotation_Maq3 = TextBox3_Rotation.Text
        My.Settings.PathMaq3 = TextBox3_Path.Text

        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    ''' <summary>
    ''' Method to get value in the file
    ''' </summary>
    ''' <param name="File">Pathname File</param>
    ''' <param name="Identifier">Word to find the value</param>
    ''' <returns>true = success</returns>
    ''' <remarks></remarks>
    Public Function GetItem(ByVal File As String, ByVal Identifier As String) As String
        Dim s As New IO.StreamReader(File) : Dim Result As String = ""
        Try
            Do While (s.Peek <> -1)
                Dim Line As String = s.ReadLine
                If Line.ToLower.StartsWith(Identifier.ToLower & ":") Then
                    Result = Line.Substring(Identifier.Length + 2)
                End If
            Loop
            s.Close()
        Catch ex As Exception

        End Try

        Return Result
    End Function

End Class
