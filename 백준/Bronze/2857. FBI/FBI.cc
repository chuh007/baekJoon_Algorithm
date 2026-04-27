

#include <iostream>
#include <string>
using namespace std;
int main()
{
	string s1, s2, s3, s4, s5;
	bool find = false;
	cin >> s1 >> s2 >> s3 >> s4 >> s5;
	if (s1.find("FBI")!=string::npos) {
		find = true;
		cout << 1 << " ";
	}
	if (s2.find("FBI") != string::npos) {
		find = true;
		cout << 2 << " ";
	}
	if (s3.find("FBI") != string::npos) {
		find = true;
		cout << 3 << " ";
	}
	if (s4.find("FBI") != string::npos) {
		find = true;
		cout << 4 << " ";
	}
	if (s5.find("FBI") != string::npos) {
		find = true;
		cout << 5 << " ";
	}
	if (find == false) cout << "HE GOT AWAY!";
}
