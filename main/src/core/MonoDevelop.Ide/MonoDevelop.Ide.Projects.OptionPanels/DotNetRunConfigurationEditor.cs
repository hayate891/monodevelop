﻿//
// DotNetRunConfigurationEditor.cs
//
// Author:
//       Lluis Sanchez Gual <lluis@xamarin.com>
//
// Copyright (c) 2016 Xamarin, Inc (http://www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using MonoDevelop.Components;
using MonoDevelop.Ide.Execution;
using MonoDevelop.Projects;
using Xwt;
using MonoDevelop.Core;

namespace MonoDevelop.Ide.Projects.OptionPanels
{
	class DotNetRunConfigurationEditor: RunConfigurationEditor
	{
		DotNetRunConfigurationEditorWidget widget;

		public DotNetRunConfigurationEditor ()
		{
			widget = new DotNetRunConfigurationEditorWidget ();
		}

		public override Control CreateControl ()
		{
			return new XwtControl (widget);
		}

		public override void Load (Project project, SolutionItemRunConfiguration config)
		{
			widget.Load ((DotNetRunConfiguration)config);
		}

		public override void Save ()
		{
			widget.Save ();
		}
	}

	class DotNetRunConfigurationEditorWidget: VBox
	{
		RadioButton radioStartProject;
		RadioButton radioStartApp;
		Xwt.FileSelector appEntry;
		TextEntry argumentsEntry;
		FolderSelector workingDir;
		EnvironmentVariableCollectionEditor envVars;
		DotNetRunConfiguration config;
		CheckBox externalConsole;
		CheckBox pauseConsole;

		public DotNetRunConfigurationEditorWidget ()
		{
			PackStart (new Label { Markup = GettextCatalog.GetString ("Start Action") });
			var table = new Table ();
			
			table.Add (radioStartProject = new RadioButton (GettextCatalog.GetString ("Start project")), 0, 0);
			table.Add (radioStartApp = new RadioButton (GettextCatalog.GetString ("Start external program:")), 0, 1);
			table.Add (appEntry = new Xwt.FileSelector (), 1, 1, hexpand: true);
			radioStartProject.Group = radioStartApp.Group;
			table.MarginLeft = 12;
			PackStart (table);

			PackStart (new HSeparator () { MarginTop = 8, MarginBottom = 8 });
			table = new Table ();

			table.Add (new Label (GettextCatalog.GetString ("Arguments:")), 0, 0);
			table.Add (argumentsEntry = new TextEntry (), 1, 0, hexpand:true);

			table.Add (new Label (GettextCatalog.GetString ("Run in directory:")), 0, 1);
			table.Add (workingDir = new FolderSelector (), 1, 1, hexpand: true);
		
			PackStart (table);

			PackStart (new HSeparator () { MarginTop = 8, MarginBottom = 8 });

			PackStart (new Label (GettextCatalog.GetString ("Environment Variables")));
			envVars = new EnvironmentVariableCollectionEditor ();

			PackStart (envVars, true);

			PackStart (new HSeparator () { MarginTop = 8, MarginBottom = 8 });

			PackStart (externalConsole = new CheckBox (GettextCatalog.GetString ("Run on external console")));
			PackStart (pauseConsole = new CheckBox (GettextCatalog.GetString ("Pause console output")));

			radioStartProject.ActiveChanged += (sender, e) => UpdateStatus ();
			externalConsole.Toggled += (sender, e) => UpdateStatus ();
		}

		public void Load (DotNetRunConfiguration config)
		{
			this.config = config;
			if (config.StartAction == DotNetRunConfiguration.StartActions.Project)
				radioStartProject.Active = true;
			else
				radioStartApp.Active = true;
			
			appEntry.FileName = config.StartProgram.ToString ();
			argumentsEntry.Text = config.StartArguments;
			workingDir.Folder = config.StartWorkingDirectory;
			envVars.LoadValues (config.EnvironmentVariables);
			externalConsole.Active = config.ExternalConsole;
			pauseConsole.Active = config.PauseConsoleOutput;
			UpdateStatus ();
		}

		void UpdateStatus ()
		{
			appEntry.Sensitive = radioStartApp.Active;
			pauseConsole.Sensitive = externalConsole.Active;
		}

		public void Save ()
		{
			if (radioStartProject.Active)
				config.StartAction = DotNetRunConfiguration.StartActions.Project;
			else if (radioStartApp.Active)
				config.StartAction = DotNetRunConfiguration.StartActions.Program;
			config.StartProgram = appEntry.FileName;
			config.StartArguments = argumentsEntry.Text;
			config.StartWorkingDirectory = workingDir.Folder;
			config.ExternalConsole = externalConsole.Active;
			config.PauseConsoleOutput = pauseConsole.Active;
			envVars.StoreValues (config.EnvironmentVariables);

		}
	}
}
