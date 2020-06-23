Public Class INI

	'////////////////////////////// HEADER //////////////////////////////'
	Private _FilePath As String
	Private _RawContent As New List(Of String)
	Private _Sections As New List(Of INISection)

	Structure INISection
		Dim SectionName As String
		Dim Elements As List(Of INIElement)
	End Structure

	Structure INIElement
		Dim Key As String
		Dim Value As String
		Dim IsComment As Boolean
	End Structure

	'////////////////////////////// CONSTRUCTOR //////////////////////////////'
	Sub New(INIFilePath As String)

		_RawContent.AddRange(File.ReadAllLines(INIFilePath))
		ListSection()

	End Sub

	'////////////////////////////// PROPERTIES //////////////////////////////'
	ReadOnly Property FilePath As String
		Get
			Return _FilePath
		End Get
	End Property

	ReadOnly Property Sections As List(Of INISection)
		Get
			Return _Sections
		End Get
	End Property

	'////////////////////////////// REQUIRED FUNCTIONS //////////////////////////////'
	Private Sub ListSection()

		Dim splA() As String

		Dim sections As New List(Of INISection)
		Dim section As New INISection
		Dim elements As New List(Of INIElement)
		Dim element As INIElement

		For Each Line In _RawContent

			Line = Line.Trim
			If Line Like "[[]*[]]*" Then
				'Pack previous Elements to the Section
				If elements.Count > 0 Then
					section.Elements = elements
				End If
				'Pack previous Section to The INISections
				If Not section.SectionName Is Nothing Then
					sections.Add(section)
					section = New INISection
				End If

				splA = Split(Line, "]", 2)
				splA(0) = splA(0).Replace("[", "")
				section.SectionName = splA(0).Trim

				elements = New List(Of INIElement)

			ElseIf Line Like "[#]*" Then
				element.Key = ""
				element.Value = Line
				element.IsComment = True
				elements.Add(element)

			Else
				'This line is element
				If Line Like "*=*" Then
					splA = Split(Line, "=", 2)
					element.Key = splA(0).Trim
					element.Value = splA(1).Trim
					element.IsComment = False
					elements.Add(element)
				End If

			End If

		Next

		'Pack the last Elements to the Section
		If elements.Count > 0 Then
			section.Elements = elements
		End If
		'Pack the last Section to The INISections
		If Not section.SectionName Is Nothing Then
			sections.Add(section)
			section = New INISection
		End If

		_Sections = sections

	End Sub


End Class
