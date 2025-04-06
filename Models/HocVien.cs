namespace CSharpProject.Models
{
    public class HocVien
    {
        public int Id { get; set; }
        public string Hoten { get; set; } = string.Empty;
        public string Diachi { get; set; } = string.Empty;
        public string Matkhau { get; set; } = string.Empty;
        public DateTime Ngaysinh { get; set; }
        public string Sodt { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public ICollection<DangKyHoc> DangKyHocs { get; set; } = new List<DangKyHoc>();

    }
}
