#include "Worker.h"


Worker::Worker(ListBox^ listBox)
{
	this->listBox = listBox;
	searchTree = gcnew BinarySearchTree(listBox);
	randGen = gcnew Random();
	CreateRandomTree();
}

void Worker::CreateRandomTree()
{
	int sizeOfTree = 32;
	int maxValueSize = 100;

	for (int i = 0; i < sizeOfTree; i++)
	{
		searchTree->AddNode(randGen->Next(maxValueSize));
	}
}

void Worker::SearchTree(int value)
{
	listBox->Items->Clear();
	listBox->Items->Add(searchTree->Search(value));
}

void Worker::ViewSort()
{
	listBox->Items->Clear();
	searchTree->Sort();
}

void Worker::ViewUnsortedTree()
{
	listBox->Items->Clear();
	searchTree->ViewUnsrtoed();
}
