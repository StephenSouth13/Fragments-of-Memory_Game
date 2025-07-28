import PageWrapper from "../components/PageWrapper";

export default function Donate() {
  return (
    <PageWrapper>
      <section className="max-w-3xl mx-auto px-4 py-10 text-center">
        <h2 className="text-3xl font-bold mb-6">💖 Ủng hộ phát triển game</h2>
        <p className="mb-6 text-lg">
          Nếu bạn yêu thích trò chơi này và muốn hỗ trợ nhóm phát triển tiếp tục hoàn thiện sản phẩm, hãy ủng hộ chúng tôi qua các phương thức sau:
        </p>
        <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
          <div>
            <img src="/assets/qr-momo.png" alt="QR Momo" className="mx-auto w-64 rounded-md shadow" />
            <p className="mt-2 font-semibold">Momo</p>
          </div>
          <div>
            <img src="/assets/qr-paypal.png" alt="QR PayPal" className="mx-auto w-64 rounded-md shadow" />
            <p className="mt-2 font-semibold">PayPal</p>
          </div>
        </div>
        <p className="mt-8 text-sm text-gray-500 dark:text-gray-400">
          Mọi khoản ủng hộ sẽ được sử dụng để cải thiện đồ họa, âm thanh, và nâng cấp gameplay của dự án. Xin cảm ơn!
        </p>
      </section>
    </PageWrapper>
  );
}
// This page allows users to donate to support the game's development, featuring QR codes for Momo and PayPal.
// It uses a responsive layout with a centered title, description, and donation options.