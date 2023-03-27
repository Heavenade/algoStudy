using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Edge : IComparable<Edge>
{
    public int weight; //가중치
    public int node1;
    public int node2;

    public Edge(int weight, int node1, int node2)
    {
        this.weight = weight;
        this.node1 = node1;
        this.node2 = node2;
    }

    public int CompareTo(Edge other)
    {
        if (weight < other.weight)
            return -1;
        else if (weight > other.weight)
            return 1;
        else
            return 0;
    }
}

public class Solution
{
    public int solution(int n, int[,] costs)
    {
        int answer = 0;
        List<Edge> edgeList = new List<Edge>();

        // 각 간선을 모두 끊어 오름차순한다. 간선은 연결된 두 정점의 정보를 가지고 있다.
        for (int i = 0; i < costs.GetLength(0); i++)
        {
            int node1 = costs[i, 0];
            int node2 = costs[i, 1];
            Edge edge = new Edge(costs[i, 2], node1, node2);
            edgeList.Add(edge);
        }
        edgeList.Sort();


        int[] nodes = new int[n];
        for (int i = 0; i < n; i++)
            nodes[i] = i;

        // 기존 크루스칼에서 Find-Union 으로 연결을 확인하는 작업과, 연결하는 작업을 진행한다.
        for (int i = 0; i < edgeList.Count; i++)
        {
            Edge currentEdge = edgeList[i];

            if (!FindParent(nodes, currentEdge.node1, currentEdge.node2)) //사이클 방지
            {
                UnionParent(nodes, currentEdge.node1, currentEdge.node2);
                answer += currentEdge.weight;
            }
        }

        return answer;
    }



    int GetParent(int[] set, int x)
    {
        if (set[x] == x)
            return x;

        return
            set[x] = GetParent(set, set[x]); //부모의 것으로 갱신하고 반환
    }

    void UnionParent(int[] set, int a, int b)
    {
        a = GetParent(set, a);
        b = GetParent(set, b);

        if (a < b) set[b] = a;
        else set[a] = b;
    }

    bool FindParent(int[] set, int a, int b)
    {
        a = GetParent(set, a);
        b = GetParent(set, b);

        if (a == b)
            return true;
        else
            return false;
    }
}
