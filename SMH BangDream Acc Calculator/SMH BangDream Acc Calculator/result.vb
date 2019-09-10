Public Class frmResult
    Private Sub FrmResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Timer1.Interval = 2000
        Timer1.Start()
        If frmAccCalc.intPerfGrt = frmAccCalc.intCMax And frmAccCalc.intGreat = 0 Then
            pbFCStat.Image = My.Resources.cperf
        Else
            pbFCStat.Image = My.Resources.cfull
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
        Timer1.Stop()
    End Sub
End Class