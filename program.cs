using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // タプル
        List<(string question, string answer)> quiz = new List<(string, string)>
        {
            ("日本の首都はどこ？", "東京"),
            ("一番高い山は？", "富士山"),
            ("日本の国鳥は？", "キジ"),
                                           
        };

        int score = 0;

        Console.WriteLine("=== 簡単クイズ ===");
        Console.WriteLine("各質問に答えてください！\n");

        // ループ
        for (int i = 0; i < quiz.Count; i++)
        {
            Console.WriteLine($"問題 {i + 1}: {quiz[i].question}");
            Console.Write("回答: ");
            string userAnswer = Console.ReadLine();

                    if (userAnswer.Trim().ToLower() == quiz[i].answer.ToLower())
            {
                Console.WriteLine("正解！\n");
                score++;
            }
            else
            {
                Console.WriteLine($"不正解... 正しい答えは「{quiz[i].answer}」です。\n");
            }
        }

        // 結果
        Console.WriteLine("=== クイズ終了 ===");
        Console.WriteLine($"あなたのスコア: {score}/{quiz.Count}");
        
        // スコア
        if (score == quiz.Count)
        {
            Console.WriteLine("全問正解！めっちゃいいね！");
        }
        else if (score > 0)
        {
            Console.WriteLine("いいね！");
        }
        else
        {
            Console.WriteLine("次はファイト！");
        }
    }
}
