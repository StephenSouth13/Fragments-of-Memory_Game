# 🎮 The Next Generation – Game Landing Page

> Website chính thức giới thiệu game indie của nhóm phát triển trẻ tại VTC Academy.

![banner](./public/assets/banner.jpg) <!-- Thay bằng ảnh banner bạn có -->

---

## 📌 Giới thiệu

**The Next Generation** là một tựa game indie được phát triển bằng Unity, mang phong cách thư giãn, nhẹ nhàng, lấy cảm hứng từ các game như *Kind Words*.  
Website này được xây dựng để giới thiệu game, trình diễn mô hình 3D, và cho phép người chơi trải nghiệm thử game trực tiếp trên trình duyệt.

---

## ⚙️ Công nghệ sử dụng

- ⚛️ **React (Vite)** – framework xây dựng frontend nhanh, hiện đại
- 💨 **Tailwind CSS** – thiết kế UI đẹp, responsive
- 🎮 **Unity WebGL** – xuất game từ Unity và nhúng vào website
- 🌐 **Vercel** – hosting miễn phí, CI/CD tự động
- 🔥 **Firebase** – quản lý liên hệ, feedback
- 🧊 **Three.js / React Three Fiber** – hiển thị mô hình 3D trong game
- ✨ **Framer Motion** – hiệu ứng chuyển cảnh mượt mà

---

## 🗺️ Cấu trúc website

| Trang | Mô tả |
|------|------|
| `/` | Trang chủ, giới thiệu game |
| `/about` | Cốt truyện, gameplay, cảm hứng |
| `/team` | Nhóm phát triển |
| `/models` | Trình diễn mô hình 3D |
| `/donate` | QR Momo / Paypal hỗ trợ dự án |
| `/contact` | Gửi liên hệ, góp ý (Firebase) |
| `/play` | Chơi thử game (Unity WebGL) |
| `/faq` | Câu hỏi thường gặp |
| `/devlog` *(tùy chọn)* | Ghi chú quá trình phát triển |
| `/feedback` *(tùy chọn)* | Gửi đánh giá từ người chơi |

---

## 🚀 Khởi chạy local (dev)

```bash
# Cài đặt dependencies
npm install

# Chạy project ở localhost
npm run dev
Truy cập tại: http://localhost:5173

🌐 Deploy
➤ Dùng Vercel (khuyên dùng)
Push project lên GitHub

Truy cập https://vercel.com

Chọn "New Project" → Kết nối repo

Tự động deploy và xuất link public

➤ Hoặc dùng Firebase Hosting
bash
Copy
Edit
firebase init hosting
npm run build
firebase deploy
🎁 Credits
🧑‍💻 Developer: Nhóm sinh viên VTC Academy

🎨 Thiết kế 3D: Unity + Blender

📦 Mã nguồn: GitHub

❤️ Donate
Bạn có thể hỗ trợ nhóm để phát triển game tốt hơn:

Momo: QR Code

Paypal: your@email.com

📸 Screenshot
<!-- Thêm ảnh minh họa demo nếu có -->

📬 Liên hệ
