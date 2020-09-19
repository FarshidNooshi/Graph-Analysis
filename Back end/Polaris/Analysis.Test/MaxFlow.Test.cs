﻿// In The Name Of GOD

using Analysis;
using Models;
using Models.Network;
using System;
using System.Collections.Generic;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Analysis.Test
{
    public class MaxFlow_Test
    {

        GraphContainer<int, Data, int, AmountedEntity<int, int>> container = 
            new GraphContainer<int, Data, int, AmountedEntity<int, int>>(null, null);

        private void Init()
        {
            container.Nodes = new List<Node<Data, int>>();
            container.Edges = new List<Edge<AmountedEntity<int, int>, int, int>>();
            for (int i = 0; i < 6; i++)
            {
                var node = new Node<Data, int>();
                node.Data = new Data(i);
                container.Nodes.Add(node);
            }
        }

        private void AddEdgeForFlow(int from, int to, Int64 amount)
        {
            //var edge1 = new Edge<AmountedEntity<int, int>, int, int>(new AmountedData(from, to, amount), 0, dic[to].Count);
            //var edge2 = new Edge<AmountedEntity<int, int>, int, int>(new AmountedData(to, from, 0), 0, dic[from].Count);
            var edge = new Edge<AmountedEntity<int, int>, int, int>();
            edge.Data = new AmountedData(from, to, amount);
            edge.Id = new Random().Next();
            container.Edges.Add(edge);
        }

        [Fact]
        public void Test1()
        {
            Init();
            AddEdgeForFlow(0, 1, 16);
            AddEdgeForFlow(0, 2, 13); 
            AddEdgeForFlow(1, 2, 10);
            AddEdgeForFlow(1, 3, 12);
            AddEdgeForFlow(2, 1, 4);
            AddEdgeForFlow(2, 4, 14);
            AddEdgeForFlow(3, 2, 9);
            AddEdgeForFlow(3, 5, 20);
            AddEdgeForFlow(4, 3, 7);
            AddEdgeForFlow(4, 5, 4);
            var analyser = new Analyser<int, Data, int, AmountedEntity<int, int>>(container);
            var flow = analyser.GetMaxFlow(0, 5);
            Assert.AreEqual(23, flow.MaxFlowAmount);
        }

        [Fact]
        public void Test2()
        {
            Init();
            AddEdgeForFlow(0, 1, 3);
            AddEdgeForFlow(0, 2, 7);
            AddEdgeForFlow(1, 3, 9);
            AddEdgeForFlow(1, 4, 9);
            AddEdgeForFlow(2, 1, 9);
            AddEdgeForFlow(2, 4, 9);
            AddEdgeForFlow(2, 5, 4);
            AddEdgeForFlow(3, 5, 3);
            AddEdgeForFlow(4, 5, 7);
            AddEdgeForFlow(0, 4, 10);
            //graph = new Graph<int, Data, int, AmountedEntity<int, int>>(dic);
            //var flow = new MaxFlow<int, Data, int, AmountedEntity<int, int>>(graph);
            //Assert.AreEqual(14, flow.DinicMaxFlow(0, 5).MaxFlowAmount);
        }

        [Fact]
        public void Test3()
        {
            Init();
            AddEdgeForFlow(0, 1, 10);
            AddEdgeForFlow(0, 2, 10);
            AddEdgeForFlow(1, 3, 4);
            AddEdgeForFlow(1, 4, 8);
            AddEdgeForFlow(1, 2, 2);
            AddEdgeForFlow(2, 4, 9);
            AddEdgeForFlow(3, 5, 10);
            AddEdgeForFlow(4, 3, 6);
            AddEdgeForFlow(4, 5, 10);
            //graph = new Graph<int, Data, int, AmountedEntity<int, int>>(dic);
            //var flow = new MaxFlow<int, Data, int, AmountedEntity<int, int>>(graph);
            //Assert.AreEqual(19, flow.DinicMaxFlow(0, 5).MaxFlowAmount);
        }
    }
}
