Module fullScreenTest_Module

    Dim fullScreenVal As String

    Public Property fullScreenValue() As String
        Get
            Return fullScreenVal
        End Get
        Set(ByVal windowScreenVal As String)
            fullScreenVal = windowScreenVal
        End Set
    End Property
End Module
