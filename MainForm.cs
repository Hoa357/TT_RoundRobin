using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CPU_Scheduling_RoundRobin_Simulator
{
    public partial class MainForm : Form
    {
        private int quantum = 0;

        List<string> processName = new List<string> { };
        List<Gant> gantList = new List<Gant>();
        static List<Process> processList = new List<Process>();
  
        public MainForm()
        {
            InitializeComponent();
        }

        // Nút Add Time - Truyền dữ liệu Input vào bảng
        private void AddTimeButton_Click(object sender, EventArgs e)
        {
            // Ném lỗi khi người dùng nhập thiếu giá trị input
            if (string.IsNullOrWhiteSpace(ProcessNameTextBox.Text) ||
                !int.TryParse(ArrivalTimeTextBox.Text, out int arrivalTime) ||
                !int.TryParse(BurstTimeTextBox.Text, out int burstTime) ||
                !int.TryParse(QuantumTextBox.Text, out int quan))
            {
                MessageBox.Show("Vui lòng nhập tất cả giá trị hợp lệ cho tất cả các trường.");
                return;
            }

            // Ném lỗi khi người dùng nhập giá trị input không hợp lệ
            if (arrivalTime < 0 || burstTime <= 0 || quan <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho tất cả các trường.");
                return;
            }

            string name = ProcessNameTextBox.Text;
            processList.Add(new Process { processName = name, arrival = arrivalTime, burst = burstTime, rnt = burstTime });

            quantum = quan;

            DataGridView1.Rows.Add(name, arrivalTime, burstTime);

            ProcessNameTextBox.Clear();
            ArrivalTimeTextBox.Clear();
            BurstTimeTextBox.Clear();
        }

        // Tạo hàng đợi
        static void createQueue(Queue<TienTrinh> q)
        {
            int n = processList.Count;
            TienTrinh x;

            for (int i = 0; i < n; i++)
            {
                nhap1TT(out x, i);
                q.Enqueue(x);
            }
        }
        static void nhap1TT(out TienTrinh x, int i)
        {
            x = new TienTrinh();
            Process process = processList[i];

            x.tenTienTrinh = process.processName;
            x.thoiGianDen = process.arrival;
            x.thoiGianXuLy = process.burst;
        }

        // Sắp xếp tiến trình theo thứ tự tăng dần thời gian đến
        static void selectionSort(Queue<TienTrinh> q)
        {
            var arr = q.ToArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].thoiGianDen < arr[minIndex].thoiGianDen)
                    {
                        minIndex = j;
                    }
                }
                var temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            q.Clear();
            foreach (var item in arr)
            {
                q.Enqueue(item);
            }
        }

        static TienTrinh gan(string ten, int thoiGianCho, int thoiGianDen, int thoiGianXuLy)
        {
            TienTrinh h = new TienTrinh();
            h.thoiGianDen = thoiGianDen;
            h.thoiGianCho = thoiGianCho;
            h.thoiGianXuLy = thoiGianXuLy;
            h.tenTienTrinh = ten;
            return h;
        }

        // Xoa và tra ve gia tri dau tien cua hang doi
        static void deleteHead(Queue<TienTrinh> q, out TienTrinh x)
        {
            x = q.Dequeue();
        }

        static void initQueue(Queue<TienTrinh> q)
        {
            q.Clear();
        }
        static void xuLy(Queue<TienTrinh> q, Queue<TienTrinh> gant, int timeSlice)
        {
            initQueue(gant);                                // Khởi tạo hàng đợi gant
            Queue<TienTrinh> tam = new Queue<TienTrinh>();  // Tạo hàng đợi tạm thời
            int flag = 0;
            while (q.Count > 0)
            {                
                if (timeSlice >= q.Peek().thoiGianXuLy)    // TG xử lí <= Quantum
                {
                    // Thêm vào tiến trình đó vào hàng đợi gant
                    gant.Enqueue(gan(q.Peek().tenTienTrinh, q.Peek().thoiGianDen, q.Peek().thoiGianDen, q.Peek().thoiGianXuLy + q.Peek().thoiGianDen));
                }
                else
                {
                    // Quantum > TG xử lí: thực hiện tiến trình theo quantum
                    gant.Enqueue(gan(q.Peek().tenTienTrinh, q.Peek().thoiGianDen, q.Peek().thoiGianDen, timeSlice + q.Peek().thoiGianDen));
                    flag = 1;   // Đánh dấu tiến trình vẫn còn thời gian để xử lí
                }

                TienTrinh x;
                deleteHead(q, out x); // Xóa tiến trình vừa xử lí và lưu trữ vào x

                while (q.Count > 0 && q.Peek().thoiGianDen < gant.Last().thoiGianXuLy)
                {
                    TienTrinh y;
                    deleteHead(q, out y);
                    tam.Enqueue(y);
                }

                if (flag == 1) // Phần còn lại chưa được xử lí của tiến trình được đưa vào hàng đợi
                {
                    tam.Enqueue(gan(x.tenTienTrinh, timeSlice, x.thoiGianDen, x.thoiGianXuLy - timeSlice));
                }
                // Xứ lí các tiến trình trong hàng đợi tạm
                while (tam.Count > 0)
                {
                    flag = 0;
                    if (timeSlice >= tam.Peek().thoiGianXuLy)
                    {
                        gant.Enqueue(gan(tam.Peek().tenTienTrinh, gant.Last().thoiGianXuLy, tam.Peek().thoiGianDen, tam.Peek().thoiGianXuLy + gant.Last().thoiGianXuLy));
                    }
                    else
                    {
                        gant.Enqueue(gan(tam.Peek().tenTienTrinh, gant.Last().thoiGianXuLy, tam.Peek().thoiGianDen, timeSlice + gant.Last().thoiGianXuLy));
                        flag = 1;
                    }

                    while (q.Count > 0 && q.Peek().thoiGianDen < gant.Last().thoiGianXuLy)
                    {
                        TienTrinh y;
                        deleteHead(q, out y);
                        tam.Enqueue(y);
                    }

                    TienTrinh t;
                    deleteHead(tam, out t);

                    if (flag == 1)  // Phần còn lại chưa được xử lí của tiến trình được đưa vào hàng đợi
                    {
                        tam.Enqueue(gan(t.tenTienTrinh, timeSlice, t.thoiGianDen, t.thoiGianXuLy - timeSlice));
                    }
                }
            }
        }

        // Nút Submit
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (processList.Count > 0)
            {
                panel1.Controls.Clear();
                gantList.Clear();
                panel2.Controls.Clear();
                processName.Clear();
                labelTurnAroundTime.Text = "";
                labelWaitTime.Text = "";
                labelGantt.Text = "";

                Queue<TienTrinh> q = new Queue<TienTrinh>();
                Queue<TienTrinh> gant = new Queue<TienTrinh>();
                Queue<TienTrinh> ganTam = new Queue<TienTrinh>();

                createQueue(q);

                foreach (var item in q)
                {
                    ganTam.Enqueue(item);
                }

                selectionSort(q);


                xuLy(q, gant, quantum);
                bieuDoGant(gant, ganTam);

            }
        }

        void bieuDoGant(Queue<TienTrinh> q, Queue<TienTrinh> ganTam)
        {
            // Truyền dữ liệu từng tiến trình vào DS gantList
            foreach (var p in q)
            {
                gantList.Add(new Gant { processName = p.tenTienTrinh, number = p.thoiGianXuLy });
                
            }

            // Khởi tạo biến đếm, TG chờ và TG hoàn tất
            int dem = 0;        // Đếm số tiến trình 
            int tgianCho = 0;
            int tgianHT = 0;

            // Tính TG chờ và TG hoàn tất, TG chờ TB và TG hoàn tất TB
            foreach (var p in ganTam)
            {
                dem++;  // Đếm số tiến trình 
                int thoiGianHTXuLy = tinhThoiGianHT(q, p).thoiGianXuLy;
                int thoiGianHTDen = tinhThoiGianHT(q, p).thoiGianDen;
                // Chèn dữ liệu vào bảng
                DataGridView2.Rows.Add(p.tenTienTrinh, thoiGianHTXuLy - thoiGianHTDen - p.thoiGianXuLy, thoiGianHTXuLy - thoiGianHTDen);
                tgianCho += thoiGianHTXuLy - thoiGianHTDen - p.thoiGianXuLy;    // Tính TG chờ
                tgianHT += thoiGianHTXuLy - thoiGianHTDen;                      // Tình TG hoàn tất
            }
            labelTurnAroundTime.Text = "Average Turn Around Time: " + (tgianHT / dem);
            labelWaitTime.Text = "Average wait time: " + (tgianCho / dem);
        }
       
        static TienTrinh tinhThoiGianHT(Queue<TienTrinh> gant, TienTrinh x)
        {
            TienTrinh max = new TienTrinh();

            foreach (var p in gant)
            {
                if (p.tenTienTrinh == x.tenTienTrinh)
                {
                    max = p;
                }
            }
            return max;
        }

        // Nút Gant - Xuất biểu đồ gant
        private void GantButton_Click(object sender, EventArgs e)
        {
            if (gantList.Count > 0)            // Nếu DS gant có tiến trình thì tiếp tục xử lí 
            {
                int previousNumber = 0;
                panel1.Controls.Clear();
                panel2.Controls.Clear();

                int x = 100;

                // Tạo DS màu ngẫu nhiên cho gant chart
                Dictionary<string, Color> buttonColors = new Dictionary<string, Color>();

                List<Color> randomColors = new List<Color> 
                {
                    Color.Red,
                    Color.Blue,
                    Color.Green,
                    Color.Yellow,
                    Color.Orange,
                    Color.Purple,
                };

                Random random = new Random(); 
                Label label0 = new Label();
                label0.Text = "0";
                label0.AutoSize = true;         // Tự điều chỉnh kích thước
                label0.Location = new Point(x - 20, 700);           // Vị trí

                panel2.Controls.Add(label0);
                foreach (Gant gant in gantList)         // Lập DS gantList
                {
                    Button button = new Button();       // Tạo nút mới
                    button.Text = gant.processName;     // Gán tên tiến trình cho nút
                    int width = (gant.number - previousNumber) * 30;    // Tính chiều rộng nút
                    button.Width = width;                               // Đặt chiều rộng nút
                    button.Height = 30;                                 // Đặt chiều cao nút
                    button.Location = new Point(x, 484);    // XĐ tọa độ đặt nút
                    button.Margin = new Padding(0);     // Xóa bỏ khoảng trắng xung quanh nút

                    // Đặt màu cho nút gant
                    if (buttonColors.ContainsKey(button.Text))
                    {
                        button.BackColor = buttonColors[button.Text];
                    }
                    else
                    {
                        int randomColorIndex = random.Next(randomColors.Count);
                        button.BackColor = randomColors[randomColorIndex];

                        buttonColors[button.Text] = button.BackColor;

                        randomColors.RemoveAt(randomColorIndex);
                    }

                    
                    panel1.Controls.Add(button);
                    // In thời gian gant
                    Label label = new Label();
                    label.Text = gant.number.ToString();
                    label.AutoSize = true;
                    label.Margin = new Padding(width - 18, 0, 0, 0); // Canh chỉnh vị trí in TG
                    label.Location = new Point(x - 20, 700);

                    panel2.Controls.Add(label);

                    x += width; // Tăng chiều dài gant cho tiến trình tiếp theo

                    previousNumber = gant.number;       // Cập nhật TG gant mới
                }
                labelGantt.Text = "GANTT: ";    // In từ Gantt
            }
        }
        // Nút Delete - Xóa dữ liệu
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            DataGridView2.Rows.Clear();
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            processName.Clear();
            processList.Clear();
            gantList.Clear();
            labelTurnAroundTime.Text = "";
            labelWaitTime.Text = "";
            labelGantt.Text = "";
        }

        private void QuantumTextBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(QuantumTextBox.Text, out quantum);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    class Gant
    {
        public string processName { get; set; }
        public int number { get; set; }
    }
    class Process
    {
        public string processName { get; set; }
        public int arrival { get; set; }
        public int burst { get; set; }
        public int rnt { get; set; }
    }
    struct TienTrinh
    {
        public string tenTienTrinh;
        public int thoiGianDen;
        public int thoiGianXuLy;
        public int thoiGianCho;
    }
}
