#include <iostream>
#include <vector>
#include <string>
#include <unordered_map>

using namespace std;

int main()
{
	int t;
	cin >> t;
	cin.ignore();
	string s, name, say;
	for (int i = 0; i < t; i++)
	{
		unordered_map<string, string> map;
		vector<string> arr;
		getline(cin, s);
		size_t pos = 0;
		while (pos < s.size())
		{
			size_t next = s.find(' ', pos);
			if (next == string::npos) next = s.size();

			string word = s.substr(pos, next - pos);
			if (!word.empty()) arr.push_back(word);

			pos = next + 1;
		}
		while (true)
		{
			string line;
			getline(cin, line);
			if (line == "what does the fox say?")
				break;

			auto p1 = line.find(" goes ");
			name = line.substr(0, p1);
			say = line.substr(p1 + 6); 
			map[say] = name;
		}
		for (auto item : arr)
		{
			if (map.find(item) != map.end())
			{
				continue;
			}
			cout << item << " ";
		}
		cout << '\n';
	}
	return 0;
}