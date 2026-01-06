#include <iostream>
#include <algorithm>
using namespace std;

// CCW : 2차원상의 점 3개가 어떤 방향성으로 놓여있나 알려주는 알고리즘.
// 나중에 이거로 선분 판정같은거 한다 함
// 반시계 1, 시계 -1, 일직선 0
int CCW(int x1, int y1, int x2, int y2, int x3, int y3)
{
    // 신발끈 공식
    // 삼각형 넓이 구하는 관점으로 봤을때
    // 0 : 그냥 세 점이 다 일직선에 있어서 넓이가 0임
    // 양수 : 원래 공식대로 반시계로 배치된거
    // 음수 : 원래 공식과 달리 시계 방향으로 배치된거
    int s = (x1 * y2 + x2 * y3 + x3 * y1) - (x2 * y1 + x3 * y2 + x1 * y3);
    return s == 0 ? 0 : s > 0 ? 1 : -1;
}

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    
    //CCW
    int x1, y1, x2, y2, x3, y3;
    cin >> x1 >> y1 >> x2 >> y2 >> x3 >> y3;
    cout << CCW(x1, y1, x2, y2, x3, y3);

    return 0;
}
