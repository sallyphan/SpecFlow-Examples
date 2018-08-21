﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by SpecFlow (http://www.specflow.org/).
'     SpecFlow Version:2.4.0.0
'     SpecFlow Generator Version:2.4.0.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
#Region "Designer generated code"
'#pragma warning disable
Imports TechTalk.SpecFlow

Namespace Global.Bowling.Specflow.Features
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0"),  _
     System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()>  _
    Partial Public Class ScoreCalculationFeature
        
        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner
        
        Private _testContext As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext
        
#ExternalSource("ScoreCalculation.feature",1)
#End ExternalSource
        
        Public Overridable Property TestContext() As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext
            Get
                Return Me._testContext
            End Get
            Set
                Me._testContext = value
            End Set
        End Property
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()>  _
        Public Shared Sub FeatureSetup(ByVal testContext As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(Nothing, 0)
            Dim featureInfo As TechTalk.SpecFlow.FeatureInfo = New TechTalk.SpecFlow.FeatureInfo(New System.Globalization.CultureInfo("en-US"), "Score Calculation", "  In order to know my performance"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  As a player"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  I want the system to calculat"& _ 
                    "e my total score", ProgrammingLanguage.VB, CType(Nothing,String()))
            testRunner.OnFeatureStart(featureInfo)
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()>  _
        Public Shared Sub FeatureTearDown()
            testRunner.OnFeatureEnd
            testRunner = Nothing
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()>  _
        Public Overridable Sub TestInitialize()
            If ((Not (testRunner.FeatureContext) Is Nothing)  _
                        AndAlso (testRunner.FeatureContext.FeatureInfo.Title <> "Score Calculation")) Then
                Global.Bowling.Specflow.Features.ScoreCalculationFeature.FeatureSetup(Nothing)
            End If
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()>  _
        Public Overridable Sub ScenarioTearDown()
            testRunner.OnScenarioEnd
        End Sub
        
        Public Overridable Sub ScenarioInitialize(ByVal scenarioInfo As TechTalk.SpecFlow.ScenarioInfo)
            testRunner.OnScenarioInitialize(scenarioInfo)
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs(Of Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)(_testContext)
        End Sub
        
        Public Overridable Sub ScenarioStart()
            testRunner.OnScenarioStart
        End Sub
        
        Public Overridable Sub ScenarioCleanup()
            testRunner.CollectScenarioErrors
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Gutter game"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Score Calculation")>  _
        Public Overridable Sub GutterGame()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Gutter game", Nothing, CType(Nothing,String()))
#ExternalSource("ScoreCalculation.feature",6)
Me.ScenarioInitialize(scenarioInfo)
            Me.ScenarioStart
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",7)
  testRunner.Given("a new bowling game", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",8)
  testRunner.When("all of my balls are landing in the gutter", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",9)
  testRunner.Then("my total score should be 0", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Beginners game"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Score Calculation")>  _
        Public Overridable Sub BeginnersGame()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Beginners game", Nothing, CType(Nothing,String()))
#ExternalSource("ScoreCalculation.feature",11)
Me.ScenarioInitialize(scenarioInfo)
            Me.ScenarioStart
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",12)
  testRunner.Given("a new bowling game", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",13)
  testRunner.When("I roll 2 and 7", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",14)
  testRunner.And("I roll 3 and 4", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",15)
  testRunner.And("I roll 8 times 1 and 1", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",16)
  testRunner.Then("my total score should be 32", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Another beginners game"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Score Calculation")>  _
        Public Overridable Sub AnotherBeginnersGame()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Another beginners game", Nothing, CType(Nothing,String()))
#ExternalSource("ScoreCalculation.feature",18)
Me.ScenarioInitialize(scenarioInfo)
            Me.ScenarioStart
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",19)
  testRunner.Given("a new bowling game", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",20)
  testRunner.When("I roll the following series:"&Global.Microsoft.VisualBasic.ChrW(9)&"2,7,3,4,1,1,5,1,1,1,1,1,1,1,1,1,1,1,5,1", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",21)
  testRunner.Then("my total score should be 40", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("All Strikes"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Score Calculation")>  _
        Public Overridable Sub AllStrikes()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("All Strikes", Nothing, CType(Nothing,String()))
#ExternalSource("ScoreCalculation.feature",23)
Me.ScenarioInitialize(scenarioInfo)
            Me.ScenarioStart
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",24)
  testRunner.Given("a new bowling game", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",25)
  testRunner.When("all of my rolls are strikes", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",26)
  testRunner.Then("my total score should be 300", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("One single spare"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Score Calculation")>  _
        Public Overridable Sub OneSingleSpare()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("One single spare", Nothing, CType(Nothing,String()))
#ExternalSource("ScoreCalculation.feature",28)
Me.ScenarioInitialize(scenarioInfo)
            Me.ScenarioStart
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",29)
   testRunner.Given("a new bowling game", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",30)
   testRunner.When("I roll the following series: 2,8,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",31)
   testRunner.Then("my total score should be 29", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("All spares"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Score Calculation")>  _
        Public Overridable Sub AllSpares()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("All spares", Nothing, CType(Nothing,String()))
#ExternalSource("ScoreCalculation.feature",33)
Me.ScenarioInitialize(scenarioInfo)
            Me.ScenarioStart
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",34)
  testRunner.Given("a new bowling game", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",35)
  testRunner.When("I roll 10 times 1 and 9", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",36)
  testRunner.And("I roll 1", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("ScoreCalculation.feature",37)
  testRunner.Then("my total score should be 110", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
    End Class
End Namespace
'#pragma warning restore
#End Region
