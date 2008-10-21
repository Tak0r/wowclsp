#pragma once


namespace WoWCLSP {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO;
	using namespace System::Diagnostics;


	bool abort = false;

	/// <summary>
	/// Zusammenfassung für Form1
	///
	/// Warnung: Wenn Sie den Namen dieser Klasse ändern, müssen Sie auch
	///          die Ressourcendateiname-Eigenschaft für das Tool zur Kompilierung verwalteter Ressourcen ändern,
	///          das allen RESX-Dateien zugewiesen ist, von denen diese Klasse abhängt.
	///          Anderenfalls können die Designer nicht korrekt mit den lokalisierten Ressourcen
	///          arbeiten, die diesem Formular zugewiesen sind.
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Konstruktorcode hier hinzufügen.
			//
		}

	protected:
		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  btn_combatlog;
	private: System::Windows::Forms::Button^  btn_split;
	private: System::Windows::Forms::Button^  btn_abort;
	private: System::Windows::Forms::ProgressBar^  progress_parse;

	protected: 

	protected: 



	private: System::Windows::Forms::Label^  lbl_logname;
	private: System::Windows::Forms::Label^  lbl_stats;
	private: System::Windows::Forms::OpenFileDialog^  dlg_combatlog;


	private:
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid));
			this->btn_combatlog = (gcnew System::Windows::Forms::Button());
			this->btn_split = (gcnew System::Windows::Forms::Button());
			this->btn_abort = (gcnew System::Windows::Forms::Button());
			this->progress_parse = (gcnew System::Windows::Forms::ProgressBar());
			this->lbl_logname = (gcnew System::Windows::Forms::Label());
			this->lbl_stats = (gcnew System::Windows::Forms::Label());
			this->dlg_combatlog = (gcnew System::Windows::Forms::OpenFileDialog());
			this->SuspendLayout();
			// 
			// btn_combatlog
			// 
			this->btn_combatlog->Location = System::Drawing::Point(13, 13);
			this->btn_combatlog->Name = L"btn_combatlog";
			this->btn_combatlog->Size = System::Drawing::Size(110, 23);
			this->btn_combatlog->TabIndex = 0;
			this->btn_combatlog->Text = L"Load Combatlog";
			this->btn_combatlog->UseVisualStyleBackColor = true;
			this->btn_combatlog->Click += gcnew System::EventHandler(this, &Form1::btn_combatlog_Click);
			// 
			// btn_split
			// 
			this->btn_split->Enabled = false;
			this->btn_split->Location = System::Drawing::Point(13, 52);
			this->btn_split->Name = L"btn_split";
			this->btn_split->Size = System::Drawing::Size(110, 23);
			this->btn_split->TabIndex = 1;
			this->btn_split->Text = L"Split";
			this->btn_split->UseVisualStyleBackColor = true;
			this->btn_split->Click += gcnew System::EventHandler(this, &Form1::btn_split_Click);
			// 
			// btn_abort
			// 
			this->btn_abort->Enabled = false;
			this->btn_abort->Location = System::Drawing::Point(13, 52);
			this->btn_abort->Name = L"btn_abort";
			this->btn_abort->Size = System::Drawing::Size(110, 23);
			this->btn_abort->TabIndex = 2;
			this->btn_abort->Text = L"Cancel";
			this->btn_abort->UseVisualStyleBackColor = true;
			this->btn_abort->Visible = false;
			this->btn_abort->Click += gcnew System::EventHandler(this, &Form1::btn_abort_Click);
			// 
			// progress_parse
			// 
			this->progress_parse->Location = System::Drawing::Point(13, 87);
			this->progress_parse->Name = L"progress_parse";
			this->progress_parse->Size = System::Drawing::Size(412, 23);
			this->progress_parse->TabIndex = 3;
			// 
			// lbl_logname
			// 
			this->lbl_logname->Location = System::Drawing::Point(129, 13);
			this->lbl_logname->Name = L"lbl_logname";
			this->lbl_logname->Size = System::Drawing::Size(296, 23);
			this->lbl_logname->TabIndex = 4;
			// 
			// lbl_stats
			// 
			this->lbl_stats->Location = System::Drawing::Point(132, 52);
			this->lbl_stats->Name = L"lbl_stats";
			this->lbl_stats->Size = System::Drawing::Size(293, 23);
			this->lbl_stats->TabIndex = 5;
			// 
			// dlg_combatlog
			// 
			this->dlg_combatlog->FileName = L"WoWCombatLog.txt";
			this->dlg_combatlog->Filter = L"Textfiles|*.txt|All Files|*.*";
			this->dlg_combatlog->FileOk += gcnew System::ComponentModel::CancelEventHandler(this, &Form1::dlg_combatlog_FileOk);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(441, 122);
			this->Controls->Add(this->lbl_stats);
			this->Controls->Add(this->lbl_logname);
			this->Controls->Add(this->progress_parse);
			this->Controls->Add(this->btn_abort);
			this->Controls->Add(this->btn_split);
			this->Controls->Add(this->btn_combatlog);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^  >(resources->GetObject(L"$this.Icon")));
			this->Name = L"Form1";
			this->Text = L"WoWCLSP";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void btn_combatlog_Click(System::Object^  sender, System::EventArgs^  e) {
				 dlg_combatlog->ShowDialog();
			 }
private: System::Void dlg_combatlog_FileOk(System::Object^  sender, System::ComponentModel::CancelEventArgs^  e) {
			// Datei ausgewählt Split Button freigeben
			btn_split->Visible = true;
			btn_split->Enabled = true;
			lbl_logname->Text = Path::GetFileName(dlg_combatlog->FileName);
			abort = false; // Abort var resetten falls vorher mal abgebrochen wurde!
		 }

private: System::Void btn_abort_Click(System::Object^  sender, System::EventArgs^  e) {
			btn_abort->Visible = false;
			btn_abort->Enabled = false;
			btn_split->Visible = true;
			btn_split->Enabled = false;
			btn_combatlog->Enabled = true;
			abort = true;
		 }

private: System::Void btn_split_Click(System::Object^  sender, System::EventArgs^  e) {
			// Split Button verstecken nach klick und Abbruch Button 
			// aktivieren. Zusätzlich Combatlog Button deaktivieren
			btn_split->Visible = false;
			btn_split->Enabled= false;
			btn_abort->Visible = true;
			btn_abort->Enabled = true;
			btn_combatlog->Enabled = false;

			// Datei Parsen

			String ^file = dlg_combatlog->FileName;
			String ^path = Path::GetDirectoryName(file);
			String ^line = String::Empty;
			String ^writelog = String::Empty;
			String ^newlogname = String::Empty;
			String ^oldlogname = String::Empty;
			String ^logname = String::Empty;
			DateTime ^lastdate = gcnew DateTime(2000, 1, 1); // Letztes Datum einstellen!
			DateTime ^currdate = DateTime::Now;
			TimeSpan ^timediff = gcnew TimeSpan;

			long line_count = 0;
			int diff_logs = 0;

			Stopwatch ^parsetime = gcnew Stopwatch();

			parsetime->Start();

			// Filestream erstellen
			FileStream ^fs_olog = nullptr;
			FileStream ^fs_nlog = nullptr;
			// Streamreader erstellen
			StreamReader ^sr_olog = nullptr;
			StreamWriter ^sw_nlog = nullptr;

			// Zu Splittende Logdatei öffnen!
			try
			{
				fs_olog = gcnew FileStream(file, FileMode::Open, FileAccess::Read);
				sr_olog = gcnew StreamReader(fs_olog);
			}
			catch(...)
			{
				lbl_logname->Text = "Cannot open " + Path::GetFileName(file);
				return;
			}

			//ProgressBar Maximum				
			progress_parse->Maximum = (int)fs_olog->Length;	

			while (!abort && (line = sr_olog->ReadLine()) != nullptr)
			{
				// Format: 6/8 14:58:33.943 -> M(M)/D(D) HH:MM:SS:TTT
				// 
				// Da das Jahr nicht angeben ist gehen wir vom Jetzignen Jahr aus
				// ggf später noch nen check einbauen ob wir uns bereits im jeweiligen Monat 
				// des Jahres befinden (im Normalfall schon)
				String ^timestamp = line->Split(gcnew array<Char> { '.' })[0];
				array<String^> ^timearr = timestamp->Split(gcnew array<Char> { ' ' });
				array<String^> ^date = timearr[0]->Split(gcnew array<Char> { '/' });
				array<String^> ^time = timearr[1]->Split(gcnew array<Char> { ':' });
				
				// Zeilendatum reinprügeln
				DateTime ^linedate = gcnew DateTime(
										currdate->Year,  // Jahr
										Convert::ToInt32(date[0]), // Monat
										Convert::ToInt32(date[1]), // Tag
										Convert::ToInt32(time[0]), // Stunde
										Convert::ToInt32(time[1]), // Minute
										Convert::ToInt32(time[2]) // Sekunde
									);
				// Differenz zwischen letzter und aktueller Zeile bilden
				timediff = linedate->Subtract(*lastdate);

				// Zeit der letzten Zeile übernehmen!
				lastdate = linedate;

				// wenn die zeitspanne der letzten Zeile größer als 2 stunden ist oder 
				// Die erste zeile eingelesen wurde neue logdatei erstellen und in diese schreiben
				if (Convert::ToInt32(timediff->TotalSeconds) > 7200 || line_count == 0)
				{
					logname = String::Format("WoWCombatLog_{0:00}{1:00}{2:0000}_{3:00}{4:00}.txt",
													lastdate->Day,
													lastdate->Month,
													lastdate->Year,
													lastdate->Hour,
													lastdate->Minute
												);
					newlogname = path + "\\" + logname;

					lbl_logname->Text = logname;
					diff_logs++;

					if (oldlogname != newlogname && !String::IsNullOrEmpty(oldlogname))
					{
						sw_nlog->Close();
						fs_nlog->Close();                        
					}

					// Neue Datei öffnen!
					try
					{
						fs_nlog = gcnew FileStream(newlogname, FileMode::Append, FileAccess::Write);
						sw_nlog = gcnew StreamWriter(fs_nlog);
					}
					catch(...)
					{
						lbl_logname->Text = "Cannot open " + newlogname;
						return;
					}

					// Speichern um später zu vergleichen
					oldlogname = newlogname;
				}

				// Aktuelle Zeile in Log schreiben
				sw_nlog->WriteLine(line);

				line_count++;

				// Progressbar füllen =)
				progress_parse->Value = (int)sr_olog->BaseStream->Position;       
				
				//percent_prg = (double)progress_parse->Value/(double)progress_parse->Maximum;

				// Anwendungsform bitte refreshen!
				Application::DoEvents();
			} // end While

			// Handler schließen        
			sr_olog->Close();
			sw_nlog->Close();
			fs_nlog->Close();
			progress_parse->Value = 0;

			parsetime->Stop();

			// Get the elapsed time as a TimeSpan value.
			TimeSpan ^ts = parsetime->Elapsed;

			lbl_stats->Text = String::Format("Benötigte Zeit: {0:00}:{1:00}.{2:00} Sekunden, {3} Logs erstellt, {4} Zeilen verarbeitet",
											ts->Minutes, ts->Seconds,
											ts->Milliseconds / 10, diff_logs, line_count);
		 }
private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
		 }
};
}

