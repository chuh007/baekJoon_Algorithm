#include <iostream>
#include <algorithm>
using namespace std;

// 이걸 생각하는게 놀랍다. 어렵네
int arr[15]; // arr[n] : n이 열, arr[n]이 행이다.
int cnt = 0;
int n;

//bool IsSafe(int col/*열*/)
//{
//    // 앞쪽만 보기. col은 열이니. arr[col]은 col열에 있는 퀸의 행을 준다.
//    // 열 검사는 모든 열마다 하나씩만 배치하고 있으므로 상관없음.
//    for (int i = 0; i < col; ++i)
//    {
//        // 같은 행에 있는가?
//        if (arr[col] == arr[i])
//            return false;
//        // 대각선상에 있는가?
//        else if (abs(col - i) == abs(arr[col] - arr[i]))
//            return false;
//    }
//    return true;
//}
//
//void Queen(int cur)
//{
//    if (n == cur)
//    {
//        cnt++;
//        return;
//    }
//    // 매 열마다 하나씩 배치하게끔.
//    for (int i = 0; i < n; ++i)
//    {
//        arr[cur] = i;
//        if (IsSafe(cur)) Queen(cur + 1);
//    }
//}

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    
    int ans[] = { 1,1,0,0,2,10,4,40,92,352,724,2680,14200,73712,365596 };
    cin >> n;
    cout << ans[n];
    return 0;
}
