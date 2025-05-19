#include <iostream>

using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    int N, M, V, K;
    int list[200002];
    cin >> N >> M >> V;
    for (int i = 1; i <= N; i++)
    {
        cin >> list[i];
    }
    for (int i = 0; i < M; i++)
    {
        cin >> K;
        if (K < N)
        {
            cout << list[1 + K] << "\n";
        }
        else
        {
            cout << list[V + (K - N) % (N - V + 1)] << "\n";
        }
    }
}