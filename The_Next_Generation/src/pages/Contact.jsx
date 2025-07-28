import { useState } from "react";
import { db } from "../firebase";
import { ref, push } from "firebase/database";
import PageWrapper from "../components/PageWrapper";

export default function Contact() {
  const [form, setForm] = useState({ name: "", message: "" });

  const handleChange = (e) => {
    setForm({ ...form, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    await push(ref(db, "contacts"), form);
    alert("Cảm ơn bạn đã liên hệ!");
    setForm({ name: "", message: "" });
  };

  return (
    <PageWrapper>
      <section className="max-w-xl mx-auto p-6">
        <h2 className="text-2xl font-bold mb-4 text-center">Liên hệ với chúng tôi</h2>
        <form onSubmit={handleSubmit} className="space-y-4">
          <input
            type="text"
            name="name"
            placeholder="Tên của bạn"
            value={form.name}
            onChange={handleChange}
            className="w-full p-2 border rounded"
            required
          />
          <textarea
            name="message"
            placeholder="Lời nhắn"
            value={form.message}
            onChange={handleChange}
            className="w-full p-2 border rounded"
            required
          />
          <button
            type="submit"
            className="bg-primary text-white px-4 py-2 rounded hover:bg-blue-700"
          >
            Gửi
          </button>
        </form>
      </section>
    </PageWrapper>
  );
}
