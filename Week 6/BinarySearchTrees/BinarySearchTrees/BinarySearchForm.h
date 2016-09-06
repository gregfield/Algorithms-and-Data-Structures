#pragma once
#include "Worker.h"

namespace BinarySearchTrees {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for BinarySearchForm
	/// </summary>
	public ref class BinarySearchForm : public System::Windows::Forms::Form
	{
	public:
		BinarySearchForm(void)
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
		~BinarySearchForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ListBox^  listBox1;
	protected:
	private: System::Windows::Forms::TextBox^  inputTxtBox;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Button^  searchBtn;
	private: System::Windows::Forms::Button^  sortBtn;
	private: System::Windows::Forms::Button^  viewTreeBtn;

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
			this->listBox1 = (gcnew System::Windows::Forms::ListBox());
			this->inputTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->searchBtn = (gcnew System::Windows::Forms::Button());
			this->sortBtn = (gcnew System::Windows::Forms::Button());
			this->viewTreeBtn = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// listBox1
			// 
			this->listBox1->FormattingEnabled = true;
			this->listBox1->ItemHeight = 16;
			this->listBox1->Location = System::Drawing::Point(51, 48);
			this->listBox1->Name = L"listBox1";
			this->listBox1->Size = System::Drawing::Size(213, 548);
			this->listBox1->TabIndex = 0;
			// 
			// inputTxtBox
			// 
			this->inputTxtBox->Location = System::Drawing::Point(398, 62);
			this->inputTxtBox->Name = L"inputTxtBox";
			this->inputTxtBox->Size = System::Drawing::Size(237, 22);
			this->inputTxtBox->TabIndex = 1;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(299, 65);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(93, 17);
			this->label1->TabIndex = 2;
			this->label1->Text = L"SearchValue:";
			// 
			// searchBtn
			// 
			this->searchBtn->Location = System::Drawing::Point(433, 123);
			this->searchBtn->Name = L"searchBtn";
			this->searchBtn->Size = System::Drawing::Size(166, 69);
			this->searchBtn->TabIndex = 3;
			this->searchBtn->Text = L"Search";
			this->searchBtn->UseVisualStyleBackColor = true;
			this->searchBtn->Click += gcnew System::EventHandler(this, &BinarySearchForm::searchBtn_Click);
			// 
			// sortBtn
			// 
			this->sortBtn->Location = System::Drawing::Point(433, 219);
			this->sortBtn->Name = L"sortBtn";
			this->sortBtn->Size = System::Drawing::Size(166, 69);
			this->sortBtn->TabIndex = 4;
			this->sortBtn->Text = L"Sort";
			this->sortBtn->UseVisualStyleBackColor = true;
			this->sortBtn->Click += gcnew System::EventHandler(this, &BinarySearchForm::sortBtn_Click);
			// 
			// viewTreeBtn
			// 
			this->viewTreeBtn->Location = System::Drawing::Point(433, 312);
			this->viewTreeBtn->Name = L"viewTreeBtn";
			this->viewTreeBtn->Size = System::Drawing::Size(166, 69);
			this->viewTreeBtn->TabIndex = 5;
			this->viewTreeBtn->Text = L"View Tree";
			this->viewTreeBtn->UseVisualStyleBackColor = true;
			this->viewTreeBtn->Click += gcnew System::EventHandler(this, &BinarySearchForm::viewTreeBtn_Click);
			// 
			// BinarySearchForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(750, 627);
			this->Controls->Add(this->viewTreeBtn);
			this->Controls->Add(this->sortBtn);
			this->Controls->Add(this->searchBtn);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->inputTxtBox);
			this->Controls->Add(this->listBox1);
			this->Name = L"BinarySearchForm";
			this->Text = L"BinarySearchForm";
			this->Load += gcnew System::EventHandler(this, &BinarySearchForm::BinarySearchForm_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private:
		Worker^ worker;

	private: System::Void BinarySearchForm_Load(System::Object^  sender, System::EventArgs^  e) 
	{
		worker = gcnew Worker(listBox1);
	}

	private: System::Void searchBtn_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		worker->SearchTree(GetSearchValue());
	}

	private: System::Void sortBtn_Click(System::Object^  sender, System::EventArgs^  e)
	{
		worker->ViewSort();
	}

	private: int GetSearchValue()
	{
		return Convert::ToInt32(inputTxtBox->Text->ToString());
	}

	private: System::Void viewTreeBtn_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		worker->ViewUnsortedTree();
	}
};
}
