import { useState } from "react";
import { db } from "../firebase";
import { ref, push } from "firebase/database";
import PageWrapper from "../components/PageWrapper";

export default function Feedback() {
  const [formData, setFormData] = useState({ name: "", rating: "", message: "" });
  const [sent, setSent] = useState(false);

  const handleSubmit = async (e) => {
    e.preventDefault();
    const feedbackRef = ref(db, "feedbacks");
    await push(feedbackRef, {
      ...formData,
      createdAt: new Date().toISOString()
    });
    setSent(true);
    setFormData({ name: "", rating: "", message: "" });
  };

  return (
    <PageWrapper>
      <section className="py-10 px-6 max-w-xl mx-auto">
        <h2 className="text-3xl font-bold mb-6">🌟 Góp ý & Đánh giá</h2>
        {sent && <p className="text-green-500 mb-4">✅ Cảm ơn bạn đã gửi đánh giá!</p>}
        <form onSubmit={handleSubmit} className="space-y-4">
          <input
            type="text"
            placeholder="Tên của bạn"
            value={formData.name}
            onChange={(e) => setFormData({ ...formData, name: e.target.value })}
            className="w-full p-2 border rounded"
            required
          />
          <select
            value={formData.rating}
            onChange={(e) => setFormData({ ...formData, rating: e.target.value })}
            className="w-full p-2 border rounded"
            required
          >
            <option value="">Chọn mức đánh giá</option>
            <option value="5">🌟🌟🌟🌟🌟 - Rất hay</option>
            <option value="4">🌟🌟🌟🌟 - Tốt</option>
            <option value="3">🌟🌟🌟 - Bình thường</option>
            <option value="2">🌟🌟 - Cần cải thiện</option>
            <option value="1">🌟 - Tệ</option>
          </select>
          <textarea
            placeholder="Nội dung góp ý..."
            value={formData.message}
            onChange={(e) => setFormData({ ...formData, message: e.target.value })}
            className="w-full p-2 border rounded h-32"
            required
          ></textarea>
          <button type="submit" className="bg-primary text-white px-4 py-2 rounded hover:bg-blue-600">
            Gửi đánh giá
          </button>
        </form>
      </section>
    </PageWrapper>
  );
}
// This page allows users to submit feedback and ratings for the game.
// It includes a form for users to enter their name, rating, and message.