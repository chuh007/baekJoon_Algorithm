#include <iostream>
#include <vector>

using namespace std;

// 새그먼트 트리
// 더럽게 어렵네
// 지금까지 알고리즘 지식의 집대성 느낌. 이진 트리 + 이탐(분할정복) + 구간합
// 배열로 트리 만드는 것도 써야함

long long n;
vector<long long> tree;
vector<long long> arr;

// cur : 트리상 인덱스. left, right : 지금 노드가 커버하는 범위
void createTree(long long cur, int left, int right)
{
    // 트리 바닥까지 옴
    if (left == right)
    {
        tree[cur] = arr[left];
        return;
    }

    // 이탐
    int mid = (left + right) / 2;
    createTree(cur * 2, left, mid);
    createTree(cur * 2 + 1, mid + 1, right);
    tree[cur] = tree[cur * 2] + tree[cur * 2 + 1]; // 배열 트리 방법으로 값 가져오기
}

// cur : 트리상 인덱스. start, end : cur가 담고 있는 범위. left right : 찾는 범위
long long query(long long cur, int start, int end, int left, int right)
{
    if (left > end || right < start) return 0; // 찾는 범위 밖이면 안함
    if (left <= start && end <= right) return tree[cur]; // 범위 전체가 구하는 범위 안이면 다 가져오기

    int mid = (start + end) / 2;
    return query(cur * 2, start, mid, left, right) +
        query(cur * 2 + 1, mid + 1, end, left, right); // 구간 분할해서 계산
}

// cur : 트리상 인덱스. start, end : cur가 담고 있는 범위. index, value : 바꿀 칸과 값
void update(long long cur, int start, int end, int index, long long value)
{
    if (index < start || index > end) return; // 범위 밖 거르기
    if (start == end)
    {
        tree[cur] = value; // 찾아서 갱신
        return;
    }
    int mid = (start + end) / 2;
    update(cur * 2, start, mid, index, value);
    update(cur * 2 + 1, mid + 1, end, index, value);
    // 재귀호출로 바닥을 찍고 값을 바꾼 뒤, 재귀가 끝나며 올라올 때 값을 갱신한다.
    tree[cur] = tree[cur * 2] + tree[cur * 2 + 1];
}

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    long long m, k;
    cin >> n >> m >> k;

    // 이 4의 의미
    // 1. 이진 트리의 높이는 log2 * 데이터 개수 이다.
    // 2. 포화 이진 트리는 데이터가 2^높이 - 1개 있게 된다.
    // 3. 구간의 합들을 이진 트리에 저장하는 특성상, 2^높이 - 1의 공간이 필요.
    // 4. 높이는 올림으로 연산해서 2의 거듭제곱보다 좀 더 큰 수는 더욱 막대한 공간을 먹음(N이 17이면 64칸 필요).
    // 5. 그래서 적당히 N이 얼마여도 넘지 않는 4N을 사용한다. 아무튼 수학적으로 엄밀함.
    tree.resize(n * 4);
    arr.resize(n);

    for (int i = 0; i < n; ++i)
    {
        cin >> arr[i];
    }

    createTree(1, 0, n - 1);

    long long a, b, c;
    for (long long i = 0; i < m + k; ++i)
    {
        cin >> a >> b >> c;
        if (a == 1)
        {
            update(1, 0, n - 1, b - 1, c);
        }
        else
        {
            cout << query(1, 0, n - 1, b - 1, c - 1) << "\n";
        }
    }

    return 0;
}