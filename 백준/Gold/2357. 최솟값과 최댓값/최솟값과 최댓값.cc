#include <iostream>
#include <vector>

using namespace std;

// 새그먼트 트리
// 더럽게 어렵네
// 지금까지 알고리즘 지식의 집대성 느낌. 이진 트리 + 이탐(분할정복) + 구간합
// 배열로 트리 만드는 것도 써야함

long long n;
vector<long long> maxTree;
vector<long long> minTree;
vector<long long> arr;

// cur : 트리상 인덱스. left, right : 지금 노드가 커버하는 범위
void createTree(long long cur, int left, int right)
{
    // 트리 바닥까지 옴
    if (left == right)
    {
        maxTree[cur] = arr[left];
        minTree[cur] = arr[left];
        return;
    }

    // 이탐
    int mid = (left + right) / 2;
    createTree(cur * 2, left, mid);
    createTree(cur * 2 + 1, mid + 1, right);
    maxTree[cur] = max(maxTree[cur * 2], maxTree[cur * 2 + 1]); // 배열 트리 방법으로 값 가져오기
    minTree[cur] = min(minTree[cur * 2], minTree[cur * 2 + 1]);
}

// cur : 트리상 인덱스. start, end : cur가 담고 있는 범위. left right : 찾는 범위
long long queryMax(long long cur, int start, int end, int left, int right)
{
    if (left > end || right < start) return 0; // 찾는 범위 밖이면 안함
    if (left <= start && end <= right) return maxTree[cur]; // 범위 전체가 구하는 범위 안이면 다 가져오기

    int mid = (start + end) / 2;
    return max(queryMax(cur * 2, start, mid, left, right),
        queryMax(cur * 2 + 1, mid + 1, end, left, right)); // 구간 분할해서 계산
}

long long queryMin(long long cur, int start, int end, int left, int right)
{
    if (left > end || right < start) return 1000000000; // 찾는 범위 밖이면 안함
    if (left <= start && end <= right) return minTree[cur]; // 범위 전체가 구하는 범위 안이면 다 가져오기

    int mid = (start + end) / 2;
    return min(queryMin(cur * 2, start, mid, left, right),
        queryMin(cur * 2 + 1, mid + 1, end, left, right)); // 구간 분할해서 계산
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    long long m;
    cin >> n >> m;

    // 이 4의 의미
    // 1. 이진 트리의 높이는 log2 * 데이터 개수 이다.
    // 2. 포화 이진 트리는 데이터가 2^높이 - 1개 있게 된다.
    // 3. 구간의 합들을 이진 트리에 저장하는 특성상, 2^높이 - 1의 공간이 필요.
    // 4. 높이는 올림으로 연산해서 2의 거듭제곱보다 좀 더 큰 수는 더욱 막대한 공간을 먹음(N이 17이면 64칸 필요).
    // 5. 그래서 적당히 N이 얼마여도 넘지 않는 4N을 사용한다. 아무튼 수학적으로 엄밀함.
    maxTree.resize(n * 4);
    minTree.resize(n * 4);
    arr.resize(n);

    for (int i = 0; i < n; ++i)
    {
        cin >> arr[i];
    }

    createTree(1, 0, n - 1);

    long long a, b;
    for (long long i = 0; i < m; ++i)
    {
        cin >> a >> b;
        cout << queryMin(1, 0, n - 1, a - 1, b - 1) << ' ';
        cout << queryMax(1, 0, n - 1, a - 1, b - 1) << '\n';
    }

    return 0;
}