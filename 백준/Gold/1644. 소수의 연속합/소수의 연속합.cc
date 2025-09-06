#include <iostream>
#include <vector>

using namespace std;

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(nullptr); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(nullptr); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n;
    cin >> n;
    vector<bool> isPrime(n + 1, true);
    isPrime[0] = false;
    isPrime[1] = false;
    for (long long i = 2; i * i <= n; ++i)
    {
        if (!isPrime[i]) continue;
        for (long long j = i * i; j <= n; j += i)
        {
            isPrime[j] = false;
        }
    }
    vector<int> primes;
    for (int i = 2; i <= n; ++i)
    {
        if (isPrime[i]) primes.push_back(i);
    }
    long long ans = 0, sum = 0, idx1 = 0;
    for (long long idx2 = 0; idx2 < primes.size(); ++idx2)
    {
        sum += primes[idx2];
        while (sum >= n)
        {
            if (sum == n) ++ans;
            sum -= primes[idx1++];
        }
    }
    cout << ans;
    return 0;
}
