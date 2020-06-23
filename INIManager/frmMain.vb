Imports FzINILib.INI

Public Class frmMain

  Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

    Dim ini As New INI("M:\SampleINI.ini")
    Dim nodes As TreeNode

    tvwMain.Nodes.Clear()

    If ini.Sections.Count > 0 Then
      For Each section In ini.Sections
        nodes = tvwMain.Nodes.Add(section.SectionName)
        If section.Elements.Count > 0 Then
          For Each element In section.Elements
            If Not element.IsComment Then
              nodes.Nodes.Add(element.Key + " = " + element.Value)
            End If
          Next
        End If
      Next
    End If

  End Sub
End Class
