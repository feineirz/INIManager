Public Class INI

	'////////////////////////////// HEADER //////////////////////////////'
	Private _FilePath As String
	Private _RawContent As List(Of String)
	Private _Sections As List(Of INISection)

	Structure INISection
		Dim SectionName As String
		Dim Elements As List(Of INIElement)
	End Structure

	Structure INIElement
		Dim Key As String
		Dim Value As String
	End Structure

	'////////////////////////////// CONSTRUCTOR //////////////////////////////'
	Sub New(INIFilePath As String)

		_RawContent.AddRange(File.ReadAllLines(INIFilePath))

	End Sub

	'////////////////////////////// PROPERTIES //////////////////////////////'
	ReadOnly Property FilePath
		Get
			Return _FilePath
		End Get
	End Property

	ReadOnly Property Sections
		Get
			Return _Sections
		End Get
	End Property

	'////////////////////////////// REQUIRED FUNCTIONS //////////////////////////////'
	Private Sub ListSection()

		For Each Line In _RawContent

			Line = Line.Trim
			If Line Like "[*]" Then

			End If

		Next

	End Sub


End Class
