#pragma once

namespace CppCLRWinformsProjekt {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Zusammenfassung für Form1
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
	private: System::Windows::Forms::Button^ btnprev;
	protected:
	private: System::Windows::Forms::Button^ btnplay;
	private: System::Windows::Forms::Button^ btnnext;
	private: System::Windows::Forms::TextBox^ musicName;
	private: System::Windows::Forms::Button^ btncreateplaylist;

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
			this->btnprev = (gcnew System::Windows::Forms::Button());
			this->btnplay = (gcnew System::Windows::Forms::Button());
			this->btnnext = (gcnew System::Windows::Forms::Button());
			this->musicName = (gcnew System::Windows::Forms::TextBox());
			this->btncreateplaylist = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// btnprev
			// 
			this->btnprev->Location = System::Drawing::Point(23, 169);
			this->btnprev->Name = L"btnprev";
			this->btnprev->Size = System::Drawing::Size(154, 51);
			this->btnprev->TabIndex = 0;
			this->btnprev->Text = L"prev";
			this->btnprev->UseVisualStyleBackColor = true;
			// 
			// btnplay
			// 
			this->btnplay->Location = System::Drawing::Point(359, 169);
			this->btnplay->Name = L"btnplay";
			this->btnplay->Size = System::Drawing::Size(154, 51);
			this->btnplay->TabIndex = 1;
			this->btnplay->Text = L"play";
			this->btnplay->UseVisualStyleBackColor = true;
			// 
			// btnnext
			// 
			this->btnnext->Location = System::Drawing::Point(677, 169);
			this->btnnext->Name = L"btnnext";
			this->btnnext->Size = System::Drawing::Size(154, 51);
			this->btnnext->TabIndex = 2;
			this->btnnext->Text = L"next";
			this->btnnext->UseVisualStyleBackColor = true;
			// 
			// musicName
			// 
			this->musicName->Location = System::Drawing::Point(23, 32);
			this->musicName->Name = L"musicName";
			this->musicName->Size = System::Drawing::Size(808, 22);
			this->musicName->TabIndex = 3;
			// 
			// btncreateplaylist
			// 
			this->btncreateplaylist->Location = System::Drawing::Point(333, 77);
			this->btncreateplaylist->Name = L"btncreateplaylist";
			this->btncreateplaylist->Size = System::Drawing::Size(213, 49);
			this->btncreateplaylist->TabIndex = 4;
			this->btncreateplaylist->Text = L"create playlist";
			this->btncreateplaylist->UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(967, 253);
			this->Controls->Add(this->btncreateplaylist);
			this->Controls->Add(this->musicName);
			this->Controls->Add(this->btnnext);
			this->Controls->Add(this->btnplay);
			this->Controls->Add(this->btnprev);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void Form1_Load(System::Object^ sender, System::EventArgs^ e) {
	}
};
}
