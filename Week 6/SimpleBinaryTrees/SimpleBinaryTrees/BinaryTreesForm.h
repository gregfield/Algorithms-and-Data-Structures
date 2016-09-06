#pragma once
#include "Worker.h"

namespace SimpleBinaryTrees {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for BinaryTreesForm
	/// </summary>
	public ref class BinaryTreesForm : public System::Windows::Forms::Form
	{
	public:
		BinaryTreesForm(void)
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
		~BinaryTreesForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ListBox^  listBox1;
	protected:
	private: System::Windows::Forms::Button^  buildTreeBtn;
	private: System::Windows::Forms::Button^  preorderBtn;
	private: System::Windows::Forms::Button^  inorderBtn;
	private: System::Windows::Forms::Button^  postorderBtn;
	private: System::Windows::Forms::Button^  expressionBtn;


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
			this->buildTreeBtn = (gcnew System::Windows::Forms::Button());
			this->preorderBtn = (gcnew System::Windows::Forms::Button());
			this->inorderBtn = (gcnew System::Windows::Forms::Button());
			this->postorderBtn = (gcnew System::Windows::Forms::Button());
			this->expressionBtn = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// listBox1
			// 
			this->listBox1->FormattingEnabled = true;
			this->listBox1->ItemHeight = 16;
			this->listBox1->Location = System::Drawing::Point(45, 31);
			this->listBox1->Name = L"listBox1";
			this->listBox1->Size = System::Drawing::Size(293, 436);
			this->listBox1->TabIndex = 0;
			// 
			// buildTreeBtn
			// 
			this->buildTreeBtn->Location = System::Drawing::Point(402, 41);
			this->buildTreeBtn->Name = L"buildTreeBtn";
			this->buildTreeBtn->Size = System::Drawing::Size(122, 37);
			this->buildTreeBtn->TabIndex = 1;
			this->buildTreeBtn->Text = L"Build Tree";
			this->buildTreeBtn->UseVisualStyleBackColor = true;
			this->buildTreeBtn->Click += gcnew System::EventHandler(this, &BinaryTreesForm::buildTreeBtn_Click);
			// 
			// preorderBtn
			// 
			this->preorderBtn->Location = System::Drawing::Point(402, 121);
			this->preorderBtn->Name = L"preorderBtn";
			this->preorderBtn->Size = System::Drawing::Size(122, 65);
			this->preorderBtn->TabIndex = 2;
			this->preorderBtn->Text = L"Preorder Traverse Tree";
			this->preorderBtn->UseVisualStyleBackColor = true;
			this->preorderBtn->Click += gcnew System::EventHandler(this, &BinaryTreesForm::preorderBtn_Click);
			// 
			// inorderBtn
			// 
			this->inorderBtn->Location = System::Drawing::Point(402, 205);
			this->inorderBtn->Name = L"inorderBtn";
			this->inorderBtn->Size = System::Drawing::Size(122, 66);
			this->inorderBtn->TabIndex = 3;
			this->inorderBtn->Text = L"Inorder Traverse Tree";
			this->inorderBtn->UseVisualStyleBackColor = true;
			this->inorderBtn->Click += gcnew System::EventHandler(this, &BinaryTreesForm::inorderBtn_Click);
			// 
			// postorderBtn
			// 
			this->postorderBtn->Location = System::Drawing::Point(402, 294);
			this->postorderBtn->Name = L"postorderBtn";
			this->postorderBtn->Size = System::Drawing::Size(122, 62);
			this->postorderBtn->TabIndex = 4;
			this->postorderBtn->Text = L"Postorder Traverse Tree";
			this->postorderBtn->UseVisualStyleBackColor = true;
			this->postorderBtn->Click += gcnew System::EventHandler(this, &BinaryTreesForm::postorderBtn_Click);
			// 
			// expressionBtn
			// 
			this->expressionBtn->Location = System::Drawing::Point(402, 373);
			this->expressionBtn->Name = L"expressionBtn";
			this->expressionBtn->Size = System::Drawing::Size(122, 62);
			this->expressionBtn->TabIndex = 5;
			this->expressionBtn->Text = L"Expression Parser";
			this->expressionBtn->UseVisualStyleBackColor = true;
			this->expressionBtn->Click += gcnew System::EventHandler(this, &BinaryTreesForm::expressionBtn_Click);
			// 
			// BinaryTreesForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(648, 551);
			this->Controls->Add(this->expressionBtn);
			this->Controls->Add(this->postorderBtn);
			this->Controls->Add(this->inorderBtn);
			this->Controls->Add(this->preorderBtn);
			this->Controls->Add(this->buildTreeBtn);
			this->Controls->Add(this->listBox1);
			this->Name = L"BinaryTreesForm";
			this->Text = L"BinaryTreesForm";
			this->Load += gcnew System::EventHandler(this, &BinaryTreesForm::BinaryTreesForm_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: 
		Worker^ worker;
	private: System::Void BinaryTreesForm_Load(System::Object^  sender, System::EventArgs^  e) 
	{
		worker = gcnew Worker(listBox1);
	}

	private: System::Void buildTreeBtn_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		worker->BuildTree(); 
		worker->BuildExpressionTree1();
		worker->BuildExpressionTree2();
	}

	private: System::Void preorderBtn_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		listBox1->Items->Clear();
		worker->RunTraversal(Worker::TraversalTypes::Preorder);
	}

	private: System::Void inorderBtn_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		listBox1->Items->Clear();
		worker->RunTraversal(Worker::TraversalTypes::Inorder);
	}

	private: System::Void postorderBtn_Click(System::Object^  sender, System::EventArgs^  e)
	{
		listBox1->Items->Clear();
		worker->RunTraversal(Worker::TraversalTypes::Postorder);
	}
private: System::Void expressionBtn_Click(System::Object^  sender, System::EventArgs^  e) 
{
	listBox1->Items->Clear();
	worker->expressionParser();
}
};
}
