#include "BinarySearchForm.h"

using namespace System;
using namespace System::Windows::Forms;

[STAThread]
void Main(array<String^>^ args)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	BinarySearchTrees::BinarySearchForm form;
	Application::Run(%form);
}