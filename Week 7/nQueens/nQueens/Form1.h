#pragma once
#include "nQueensTree.h"

namespace nQueens {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}

	private: System::Windows::Forms::Button^  btnSolve1D;
	protected:

	protected:

	private: System::Windows::Forms::ListBox^  listBox1;
	private: System::Windows::Forms::TextBox^  textBox1;


	private: System::Windows::Forms::Label^  label1;
	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->btnSolve1D = (gcnew System::Windows::Forms::Button());
			this->listBox1 = (gcnew System::Windows::Forms::ListBox());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// btnSolve1D
			// 
			this->btnSolve1D->Location = System::Drawing::Point(13, 92);
			this->btnSolve1D->Margin = System::Windows::Forms::Padding(4);
			this->btnSolve1D->Name = L"btnSolve1D";
			this->btnSolve1D->Size = System::Drawing::Size(191, 28);
			this->btnSolve1D->TabIndex = 0;
			this->btnSolve1D->Text = L"Solve 1D Chessboard";
			this->btnSolve1D->UseVisualStyleBackColor = true;
			this->btnSolve1D->Click += gcnew System::EventHandler(this, &Form1::btnSolve1D_Click);
			// 
			// listBox1
			// 
			this->listBox1->Font = (gcnew System::Drawing::Font(L"Courier New", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->listBox1->FormattingEnabled = true;
			this->listBox1->ItemHeight = 22;
			this->listBox1->Location = System::Drawing::Point(251, 36);
			this->listBox1->Margin = System::Windows::Forms::Padding(4);
			this->listBox1->Name = L"listBox1";
			this->listBox1->Size = System::Drawing::Size(668, 466);
			this->listBox1->TabIndex = 1;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(100, 55);
			this->textBox1->Margin = System::Windows::Forms::Padding(4);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(40, 22);
			this->textBox1->TabIndex = 2;
			this->textBox1->Text = L"4";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(12, 60);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(72, 17);
			this->label1->TabIndex = 5;
			this->label1->Text = L"N Queens";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(997, 542);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->listBox1);
			this->Controls->Add(this->btnSolve1D);
			this->Margin = System::Windows::Forms::Padding(4);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e)
	{

	}
	private: System::Void btnSolve1D_Click(System::Object^  sender, System::EventArgs^  e)
	{
		Cursor->Current = Cursors::WaitCursor;

		listBox1->Items->Clear();


		int dimension = Convert::ToInt16(textBox1->Text);

		nQueensTree^ testTree = gcnew nQueensTree(dimension);

		// fixed for n = four
		//testTree->iterativeTreeGen();

		testTree->recursiveTreeGen(testTree->rootNode, 0);

		// Uncomment to see the whole tree...
		//testTree->printTree(testTree->rootNode, listBox1);

		listBox1->Items->Add("===========================");
		listBox1->Items->Add("Solutions for " + dimension.ToString() + "-Queens");
		testTree->printSolutions(testTree->rootNode, listBox1);

		Cursor->Current = Cursors::Default;

	}
	};
}