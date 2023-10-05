Public Class Form1
    Private Sub btnShake_Click(sender As Object, e As EventArgs) Handles btnShake.Click
        Dim i As Integer
        Dim n As Integer
        For i = 1 To 25
            n = Int(26 * Rnd()) + 65

            'Declare an array for the Labels
            Dim FoundControls As Control() = Me.Controls.Find("Label" & i, True)  'Find the label with the name "Label#" - where # is the current index

            If FoundControls.Count > 0 Then

                FoundControls(0).Text = Chr(n) 'Change its text
            End If
        Next
    End Sub
End Class
