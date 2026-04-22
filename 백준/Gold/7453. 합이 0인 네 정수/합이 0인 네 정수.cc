#include <iostream>
#include <algorithm>
#include <queue>
using namespace std;

int a[4000], b[4000], c[4000], d[4000];

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int n;
	vector<int> sumAB, sumCD;
	cin >> n;
	for (int i = 0; i < n; ++i)
	{
		cin >> a[i] >> b[i] >> c[i] >> d[i];
	}
	// 시간복잡도를 N^3에서 N^2로 줄인다?
	// 상수를 겁나 올려서라도 줄인다는 느낌인가

	sumAB.reserve(n * n);
	sumCD.reserve(n * n);

	for (int i = 0; i < n; ++i)
	{
		for (int j = 0; j < n; ++j)
		{
			sumAB.push_back(a[i] + d[j]);
			sumCD.push_back(b[i] + c[j]);
		}
	}

	sort(sumAB.begin(), sumAB.end());
	sort(sumCD.begin(), sumCD.end());
	
	long long count = 0, left = 0, right = sumCD.size() - 1;

    while (left < sumAB.size() && right >= 0)
	{
        long long sum = (long long)sumAB[left] + (long long)sumCD[right];

        if (sum == 0)
		{
            long long targetAB = sumAB[left];
            long long cntAB = 0;
			long long targetCD = sumCD[right];
			long long cntCD = 0;

			// 중복된 합들도 계산하게끔
            while (left < sumAB.size() && sumAB[left] == targetAB)
			{
                cntAB++;
                left++;
            }

            while (right >= 0 && sumCD[right] == targetCD)
			{
                cntCD++;
                right--;
            }

            count += cntAB * cntCD;
        }
        else if (sum < 0)
            left++;
        else
            right--;
    }

	cout << count;

	return 0;
}