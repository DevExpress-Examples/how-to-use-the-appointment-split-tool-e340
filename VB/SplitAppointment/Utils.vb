Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraScheduler

Namespace SplitAppointment
	Public Class ResourceFiller
		Public Shared Users() As String = { "Sarah Brighton", "Ryan Fischer", "Andrew Miller" }
		Public Shared Usernames() As String = { "sbrighton", "rfischer", "amiller" }

		Public Shared Sub FillResources(ByVal storage As SchedulerStorage, ByVal count As Integer)
			Dim resources As ResourceCollection = storage.Resources.Items
			storage.BeginUpdate()
			Try
				Dim cnt As Integer = Math.Min(count, Users.Length)
				For i As Integer = 1 To cnt
					resources.Add(New Resource(Usernames(i - 1), Users(i - 1)))
				Next i
			Finally
				storage.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
