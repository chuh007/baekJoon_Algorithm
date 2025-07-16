#include <iostream>
#include <queue>

using namespace std;

struct AAndAnswer {
    int a;
    string answer;
};

int D(int n) {
    return (n * 2) % 10000;
}

int S(int n) {
    return (n == 0 ? 9999 : n - 1);
}

int L(int n) {
    return (n % 1000) * 10 + n / 1000;
}

int R(int n) {
    return (n % 10) * 1000 + n / 10;
}

string DSLR(int a, int b) {
    bool visited[10000] = { false };
    queue<AAndAnswer> q;
    q.push({ a, "" });
    visited[a] = true;

    while (!q.empty()) {
        AAndAnswer cur = q.front();
        q.pop();

        if (cur.a == b) return cur.answer;

        int next;

        next = D(cur.a);
        if (!visited[next]) {
            visited[next] = true;
            q.push({ next, cur.answer + 'D' });
        }

        next = S(cur.a);
        if (!visited[next]) {
            visited[next] = true;
            q.push({ next, cur.answer + 'S' });
        }

        next = L(cur.a);
        if (!visited[next]) {
            visited[next] = true;
            q.push({ next, cur.answer + 'L' });
        }

        next = R(cur.a);
        if (!visited[next]) {
            visited[next] = true;
            q.push({ next, cur.answer + 'R' });
        }
    }

    return "";
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    int T;
    cin >> T;
    for (int t = 0; t < T; t++)
    {
        int a, b;
        cin >> a >> b;
        cout << DSLR(a, b) << '\n';
    }
    
    return 0;
}
