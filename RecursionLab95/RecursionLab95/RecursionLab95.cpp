#include <iostream>
#include <vector>

template<class T>
struct Node
{
	T element;
	Node<T>* nextNode;
};

template<class T>
class LinkedList
{
private:
	Node<T> headNode;
	
public:

	LinkedList()
	{
		headNode = Node<T>();
	}
	
	LinkedList(T elem)
	{
		headNode = Node<T>{ elem, nullptr };
	}

	void PushToBegin(T element)
	{
		const auto addedNode = new Node<T>{ headNode.element, headNode.nextNode };
		headNode.element = element;
		headNode.nextNode = addedNode;
	}

	void AddBeforeFirstPositiveRecursive(T elem, Node<T>* prevNode = nullptr, Node<T>* currentNode = nullptr)
	{
		// If first node
		if (currentNode == nullptr)
		{
			return AddBeforeFirstPositiveRecursive(elem, nullptr, &headNode);
		}
		// If second node
		if (prevNode == nullptr)
		{
			if (currentNode->element >= 0)
			{
				auto addedNode = new Node<T>{ headNode.element, headNode.nextNode };
				headNode.element = elem;
				headNode.nextNode = addedNode;
			}
			else
			{
				return AddBeforeFirstPositiveRecursive(elem, &headNode, currentNode->nextNode);
			}
		}
		// Other
		else
		{
			if (currentNode->element >= 0)
			{
				auto addedNode = new Node<T>{ elem, currentNode };
				prevNode->nextNode = addedNode;
			}
			else
			{
				return AddBeforeFirstPositiveRecursive(elem, currentNode, currentNode->nextNode);
			}
		}
	}

	// Casual function
	void AddBeforeFirstPositive(T elem)
	{
		// If first elem is positive
		Node<T>* currentNode = &headNode;
		if (currentNode->element >= 0)
		{
			auto addedNode = new Node<T>{ headNode.element, headNode.nextNode };
			headNode.element = elem;
			headNode.nextNode = addedNode;
			return;
		}

		// Check other
		currentNode = currentNode->nextNode;
		Node<T>* previousNode = &headNode;

		while (currentNode)
		{
			if (currentNode->element >= 0)
			{
				Node<T>* addedNode = new Node<T>{ elem, currentNode };
				previousNode->nextNode = addedNode;
				return;
			}
			previousNode = currentNode;
			currentNode = currentNode->nextNode;
		}
		
	}
	
	T GetElement(int index)
	{
		Node<T> node = headNode;
		for (int i = 0; i < index; ++i)
		{
			node = *node.nextNode;
		}
		return node.element;
	}
	
};

int main()
{
	LinkedList<int> list = LinkedList<int>(5);
	list.PushToBegin(2);
	list.PushToBegin(-4);
	list.PushToBegin(-6);

	list.AddBeforeFirstPositiveRecursive(12);
	
	std::cout << list.GetElement(0) << "\n";
	std::cout << list.GetElement(1) << "\n";
	std::cout << list.GetElement(2) << "\n";
	std::cout << list.GetElement(3) << "\n";
	std::cout << list.GetElement(4) << "\n";
	
	return 0;
}