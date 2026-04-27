#include <iostream>
#include <algorithm>
using namespace std;

// CCW : 2차원상의 점 3개가 어떤 방향성으로 놓여있나 알려주는 알고리즘.
// 나중에 이거로 선분 판정같은거 한다 함
// 반시계 1, 시계 -1, 일직선 0
int CCW(pair<long, long> p1, pair<long, long> p2, pair<long, long> p3)
{
    // 신발끈 공식
    // 삼각형 넓이 구하는 관점으로 봤을때
    // 0 : 그냥 세 점이 다 일직선에 있어서 넓이가 0임
    // 양수 : 원래 공식대로 반시계로 배치된거
    // 음수 : 원래 공식과 달리 시계 방향으로 배치된거
    long s = (p1.first * p2.second + p2.first * p3.second + p3.first * p1.second)
        - (p2.first * p1.second + p3.first * p2.second + p1.first * p3.second);
    return s == 0 ? 0 : s > 0 ? 1 : -1;
}

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    
    pair<long, long> p1, p2, p3, p4;
    bool isCross = false;
    cin >> p1.first >> p1.second >> p2.first >> p2.second
        >> p3.first >> p3.second >> p4.first >> p4.second;
    
    // 두 선분 각각 기준으로 계산
    int a = CCW(p1, p2, p3);
    int b = CCW(p1, p2, p4);
    int c = CCW(p3, p4, p1);
    int d = CCW(p3, p4, p2);
    if (a * b == 0 && c * d == 0) // 세 점이 일직선상에 있다
    {
        if (p1 > p2) swap(p1, p2);
        if (p3 > p4) swap(p3, p4);
        isCross = p1 <= p4 && p3 <= p2; // 단순 좌표로 겹치면 교차함
    }
    else
    {
        isCross = a * b <= 0 && c * d <= 0; // 아니면 일반논리
    }
    cout << (isCross ? 1 : 0);

    return 0;
}
