Public Class MainForm
    Dim currentdir As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
    Const CrLf As String = Chr(13) & Chr(10)

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        For i As Integer = 0 To chlb.Items.Count - 1
            chlb.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub btnInvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvert.Click
        For i As Integer = 0 To chlb.Items.Count - 1
            chlb.SetItemChecked(i, Not chlb.GetItemChecked(i))
        Next
    End Sub

    Private Sub btnNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNone.Click
        For i As Integer = 0 To chlb.Items.Count - 1
            chlb.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btnDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDir.Click
        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            chlb.Enabled = True
            chlb.BackColor = Color.White
            currentdir = fbd.SelectedPath
            txtPath.Text = currentdir
            UpdateBoxes()
        End If
    End Sub

    Private Sub txtO_MouseClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReplace.GotFocus, txtPrepend.GotFocus
        If txtReplace.Tag.ToString = "1" Then
            txtReplace.Tag = CObj("0")
            txtReplace.Text = Nothing
        End If
    End Sub

    Private Sub txtN_MouseClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReplacedWith.GotFocus, txtAppend.GotFocus
        If txtReplacedWith.Tag.ToString = "1" Then
            txtReplacedWith.Tag = CObj("0")
            txtReplacedWith.Text = Nothing
        End If
    End Sub

    Private Sub rb_CheckChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbReplace.CheckedChanged
        txtReplacedWith.Enabled = rbReplace.Checked
    End Sub
    Private Sub txtQuickPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuickPath.TextChanged
        If txtQuickPath.TextLength > 0 Then
            btnQuickPathCancel.Show()
            btnQuickPathAct.Enabled = True
        Else
            btnQuickPathCancel.Hide()
            btnQuickPathAct.Enabled = False
        End If
    End Sub

    Private Sub btnQuickPathCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuickPathCancel.Click
        txtQuickPath.Text = Nothing
    End Sub

    Sub UpdateBoxes()
        chlb.Items.Clear()
        Dim di As New IO.DirectoryInfo(currentdir)
        Dim dfs As IO.FileInfo() = di.GetFiles
        For Each df As IO.FileInfo In dfs
            chlb.Items.Add(df, True)
        Next
    End Sub

    Private Sub btnAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAct.Click
        Dim sucess As Boolean = True
        Dim errors As String = "The following already EXIST!!!" & CrLf
        For Each fr As IO.FileInfo In chlb.CheckedItems
            If Not (New IO.FileInfo(GetNewFilePath(fr)).Exists And GetNewFilePath(fr).ToLower = fr.Name.ToLower) Then
                fr.MoveTo(GetNewFilePath(fr))
            Else
                Dim fn As String = fr.Name
                ReplaceIf(fn, txtReplace.Text, GetNewNameReplacement())
                fn = txtPrepend.Text & fn & txtAppend.Text
                If fr.Name <> fn Then
                    sucess = False
                    errors &= fr.Name & " to " & fn & CrLf
                End If
            End If
        Next
        UpdateBoxes()
        If sucess Then
            MsgBox("Files Renamed Sucessfully!!!", MsgBoxStyle.Information, "Mass Renamer")
        Else
            MsgBox(errors, MsgBoxStyle.Critical, "Mass Renamer")
        End If
    End Sub
    Function GetNewFilePath(ByVal fr As IO.FileInfo) As String
        Dim fn As String = fr.Name
        ReplaceIf(fn, txtReplace.Text, GetNewNameReplacement())
        fn = txtPrepend.Text & fn & txtAppend.Text
        Return currentdir & "\" & fn
    End Function

    Function GetNewNameReplacement() As String
        If txtReplacedWith.Enabled Then Return txtReplacedWith.Text Else Return ""
    End Function

    Function ReplaceIf(ByRef str As String, ByVal oldstr As String, ByVal newstr As String) As Boolean
        If oldstr = "" Then
            Return False
        Else
            str = str.Replace(oldstr, newstr)
            Return True
        End If
    End Function

    Private Sub btnQuickPathAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuickPathAct.Click
        If IO.Directory.Exists(txtQuickPath.Text) Then
            chlb.Enabled = True
            chlb.BackColor = Color.White
            currentdir = txtQuickPath.Text
            txtPath.Text = currentdir
            UpdateBoxes()
        Else
            txtQuickPath.Text = Nothing
        End If
    End Sub

    Private Sub ctxMenuFileSelect_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ctxMenuFileSelect.Opening
        If chlb.SelectedItem Is Nothing Then
            ctxMenuFileSelect.Enabled = False
            Exit Sub
        End If
        ctxMenuFileSelect.Enabled = True
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        Dim workingAttr As IO.FileAttributes = workingFile.Attributes
        ' Archive = 32
        If (workingAttr And 32) = 32 Then
            ctxArchive.Image = Global.MassRename.My.Resources.Resources.ctxyes
            ctxMakeArchive.Enabled = False
            ctxNoArchive.Enabled = True
        Else
            ctxArchive.Image = Global.MassRename.My.Resources.Resources.ctxno
            ctxMakeArchive.Enabled = True
            ctxNoArchive.Enabled = False
        End If
        ' Hidden = 2
        If (workingAttr And 2) = 2 Then
            ctxHidden.Image = Global.MassRename.My.Resources.Resources.ctxyes
            ctxMakeHidden.Enabled = False
            ctxNoHidden.Enabled = True
        Else
            ctxHidden.Image = Global.MassRename.My.Resources.Resources.ctxno
            ctxMakeHidden.Enabled = True
            ctxNoHidden.Enabled = False
        End If
        ' System = 4
        If (workingAttr And 4) = 4 Then
            ctxSystem.Image = Global.MassRename.My.Resources.Resources.ctxyes
            ctxMakeSystem.Enabled = False
            ctxNoSystem.Enabled = True
        Else
            ctxSystem.Image = Global.MassRename.My.Resources.Resources.ctxno
            ctxMakeSystem.Enabled = True
            ctxNoSystem.Enabled = False
        End If
        ' Read-Only = 1
        If (workingAttr And 1) = 1 Then
            ctxReadOnly.Image = Global.MassRename.My.Resources.Resources.ctxyes
            ctxMakeReadOnly.Enabled = False
            ctxNoReadOnly.Enabled = True
        Else
            ctxReadOnly.Image = Global.MassRename.My.Resources.Resources.ctxno
            ctxMakeReadOnly.Enabled = True
            ctxNoReadOnly.Enabled = False
        End If
    End Sub

    Private Sub ctxDeleteConfirmed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxDeleteConfirmed.Click
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        workingFile.Delete()
        UpdateBoxes()
    End Sub

    Private Sub ctxMakeReadOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxMakeReadOnly.Click
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        workingFile.Attributes = CType(workingFile.Attributes + IO.FileAttributes.ReadOnly, IO.FileAttributes)
    End Sub

    Private Sub ctxNoReadOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxNoReadOnly.Click
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        workingFile.Attributes = CType(workingFile.Attributes - IO.FileAttributes.ReadOnly, IO.FileAttributes)
    End Sub

    Private Sub ctxMakeHidden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxMakeHidden.Click
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        workingFile.Attributes = CType(workingFile.Attributes + IO.FileAttributes.Hidden, IO.FileAttributes)
    End Sub

    Private Sub ctxNoHidden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxNoHidden.Click
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        workingFile.Attributes = CType(workingFile.Attributes - IO.FileAttributes.Hidden, IO.FileAttributes)
    End Sub

    Private Sub ctxMakeArchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxMakeArchive.Click
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        workingFile.Attributes = CType(workingFile.Attributes + IO.FileAttributes.Archive, IO.FileAttributes)
    End Sub

    Private Sub ctxNoArchive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxNoArchive.Click
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        workingFile.Attributes = CType(workingFile.Attributes - IO.FileAttributes.Archive, IO.FileAttributes)
    End Sub

    Private Sub ctxMakeSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxMakeSystem.Click
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        workingFile.Attributes = CType(workingFile.Attributes + IO.FileAttributes.System, IO.FileAttributes)
    End Sub

    Private Sub ctxNoSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctxNoSystem.Click
        Dim workingFile As New IO.FileInfo(currentdir & "\" & CType(chlb.SelectedItem, IO.FileInfo).Name)
        workingFile.Attributes = CType(workingFile.Attributes - IO.FileAttributes.System, IO.FileAttributes)
    End Sub
End Class
