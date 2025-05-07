using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace ChatGPT_hw
{
    public partial class Form1: Form
    {
        private string apiKey = "";
        private List<object> chatHistory = new List<object>();
        private int inputCount = 0;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing; // 關閉後儲存
            this.TxtHint(); // 文字提示
            btnSend.Click += btnSend_Click;
            btnSave.Click += btnSave_Click;
        }
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = "主題: "+txtTitle.Text.Trim() + Environment.NewLine+ "收件人: " +txtRece.Text.Trim() + Environment.NewLine + "寄件人: "+txtSend.Text.Trim();
            if (string.IsNullOrEmpty(userInput)||(inputCount<3))
            {
                MessageBox.Show("請輸入完整資訊！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtChange.Text) && (txtChange.Visible == true))
            {
                MessageBox.Show("請輸入更新資訊！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(inputCount == 3&& (txtChange.Visible == true))
            {
                userInput += Environment.NewLine + "請修改這幾點: " +txtChange.Text.Trim();
            }
            chatHistory.Add(new { role = "user", content = userInput });
            btnSend.Enabled = false; // 禁用按鈕，防止多次點擊

            string response = GetOpenAIResponse();
            txtContent.Text=response;
            btnSend.Enabled = true; // 啟用按鈕

            lblChange.Visible = true;
            txtChange.Visible = true;
            btnSave.Visible = true;
            btnSave.Enabled = true;
        }

        private int fileNum=0;
        private void btnSave_Click(object sender, EventArgs e) {
            string FilePath = "紀錄"+fileNum.ToString()+".txt";
            try
            {
                using (StreamWriter writer1 = new StreamWriter(FilePath, false, Encoding.UTF8))
                {
                    writer1.WriteLine(txtContent.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存紀錄失敗" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSave.Enabled = false;
        }

        //OpenAI問問題
        private bool isSystemMessageAdded = false;
        private string GetOpenAIResponse()
        {
            var client = new RestClient("https://api.openai.com/");
            var request = new RestRequest("v1/chat/completions", Method.Post);
            request.AddHeader("Authorization", "Bearer " + apiKey);
            request.AddHeader("Content-Type", "application/json");

            if (!isSystemMessageAdded)
            {
                chatHistory.Insert(0, new { role = "system", content = "請你幫忙撰寫信件，產生出信件的標題與內容。不需要列出收件人與寄件人。" });
                isSystemMessageAdded = true;
            }

            var requestBody = new
            {
                model = "gpt-4",
                messages = chatHistory,
                max_tokens = 1000
            };

            request.AddJsonBody(JsonConvert.SerializeObject(requestBody));

            var response = client.Execute(request);
            if (response.IsSuccessful)
            {
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                string aiResponse = jsonResponse.choices[0].message.content.ToString();
                chatHistory.Add(new { role = "assistant", content = aiResponse }); // 存入歷史紀錄
                return aiResponse;
            }
            else
            {
                return "發生錯誤：" + response.StatusCode + " - " + response.Content;
            }

        }

        //文字提示
        private void TxtHint() {
            txtTitle.GotFocus += txtTitle_GotFocus;
            txtTitle.LostFocus += txtTitle_LostFocus;
            txtRece.GotFocus += txtRece_GotFocus;
            txtRece.LostFocus += txtRece_LostFocus;
            txtSend.GotFocus += txtSend_GotFocus;
            txtSend.LostFocus += txtSend_LostFocus;
        }
        private void txtTitle_GotFocus(object sender, EventArgs e)
        {
            if (txtTitle.Text == "請輸入信件主題")
            {
                txtTitle.Text = "";
                txtTitle.ForeColor = Color.Black;
                inputCount++;
            }
        }
        private void txtTitle_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                txtTitle.Text = "請輸入信件主題";
                txtTitle.ForeColor = Color.Gray;
                inputCount--;
            }
        }
        private void txtRece_GotFocus(object sender, EventArgs e)
        {
            if (txtRece.Text == "請輸入收件人姓名與稱謂")
            {
                txtRece.Text = "";
                txtRece.ForeColor = Color.Black;
                inputCount++;
            }
        }
        private void txtRece_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRece.Text))
            {
                txtRece.Text = "請輸入收件人姓名與稱謂";
                txtRece.ForeColor = Color.Gray;
                inputCount--;
            }
        }
        private void txtSend_GotFocus(object sender, EventArgs e)
        {
            if (txtSend.Text == "請輸入你的姓名")
            {
                txtSend.Text = "";
                txtSend.ForeColor = Color.Black;
                inputCount++;
            }
        }
        private void txtSend_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSend.Text))
            {
                txtSend.Text = "請輸入你的姓名";
                txtSend.ForeColor = Color.Gray;
                inputCount--;
            }
        }


        //關閉畫面，並儲存紀錄
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChatHistoryToFile();
        }
        private string chatLogFilePath = "前次歷史紀錄.txt";
        private void SaveChatHistoryToFile() 
        {
            try
            {
                using (StreamWriter writer2 = new StreamWriter(chatLogFilePath, false, Encoding.UTF8))
                {
                    for (int i = 0; i < chatHistory.Count; i ++)
                    {
                        dynamic msg = chatHistory[i];

                        if (msg.role == "system") continue;

                        if (msg.role == "user")
                        {
                            writer2.WriteLine(msg.content);
                        }
                        else if (msg.role == "assistant")
                        {
                            writer2.WriteLine(msg.content);
                        }
                        writer2.WriteLine("---");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存聊天紀錄失敗" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
