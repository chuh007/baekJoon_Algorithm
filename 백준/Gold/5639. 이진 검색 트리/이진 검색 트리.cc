#include<iostream>

using namespace std;


struct node
{
	int value;
	node* left;
	node* right;
};

node* rootnode;

void Push(node* root, node* cur)
{
	if (rootnode == NULL)
	{
		rootnode = cur;
		return;
	}
	if (root->value > cur->value)
	{
		if (root->left == NULL) root->left = cur;
		else Push(root->left, cur);
	}
	else
	{
		if (root->right == NULL) root->right = cur;
		else Push(root->right, cur);
	}
}

node* Make(int v)
{
	node* n = new node;
	n->left = NULL;
	n->right = NULL;
	n->value = v;
	return n;
}

void Print(node* n)
{
	if (n->left != NULL) Print(n->left);
	if (n->right != NULL) Print(n->right);
	cout << n->value << '\n';
}

int main()
{
	cin.tie(NULL);
	cout.tie(NULL);
	ios::sync_with_stdio(false);

	int value;
	while (cin >> value)
	{
		node* n = Make(value);
		Push(rootnode, n);
	}
	Print(rootnode);
}