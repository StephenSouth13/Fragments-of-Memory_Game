import PageWrapper from "../components/PageWrapper";

export default function FAQ() {
  const faqs = [
    {
      question: "Game này có miễn phí không?",
      answer: "Có! Bạn có thể chơi hoàn toàn miễn phí trên trình duyệt."
    },
    {
      question: "Game có hỗ trợ tiếng Việt không?",
      answer: "Có, game được phát triển với giao diện tiếng Việt và tiếng Anh."
    },
    {
      question: "Có thể chơi trên điện thoại không?",
      answer: "Hiện tại game được tối ưu cho máy tính. Phiên bản mobile sẽ ra mắt trong tương lai."
    },
    {
      question: "Tôi có thể góp ý hoặc báo lỗi ở đâu?",
      answer: "Bạn có thể sử dụng form Liên hệ hoặc Feedback ngay trên trang web."
    }
  ];

  return (
    <PageWrapper>
      <section className="max-w-3xl mx-auto px-4 py-10">
        <h2 className="text-3xl font-bold mb-6">❓ Câu hỏi thường gặp (FAQ)</h2>
        <ul className="space-y-6">
          {faqs.map((item, index) => (
            <li key={index} className="bg-gray-100 dark:bg-gray-800 p-4 rounded-lg shadow">
              <h3 className="font-semibold text-lg mb-2">{item.question}</h3>
              <p className="text-gray-700 dark:text-gray-300">{item.answer}</p>
            </li>
          ))}
        </ul>
      </section>
    </PageWrapper>
  );
}
