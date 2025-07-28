import PageWrapper from "../components/PageWrapper";

export default function Team() {
  return (
    <PageWrapper>
      <section className="py-12 px-6 max-w-5xl mx-auto">
        <h2 className="text-3xl font-bold text-center mb-10">Nhóm Phát Triển</h2>
        <div className="grid grid-cols-1 md:grid-cols-3 gap-8 text-center">
          <div>
            <img
              src="/assets/dev1.jpg"
              alt="Dev 1"
              className="w-32 h-32 rounded-full mx-auto mb-4 object-cover"
            />
            <h3 className="text-xl font-semibold">Nguyễn Văn A</h3>
            <p>Lập trình Unity</p>
          </div>
          <div>
            <img
              src="/assets/dev2.jpg"
              alt="Dev 2"
              className="w-32 h-32 rounded-full mx-auto mb-4 object-cover"
            />
            <h3 className="text-xl font-semibold">Trần Thị B</h3>
            <p>Thiết kế UI/UX</p>
          </div>
          <div>
            <img
              src="/assets/dev3.jpg"
              alt="Dev 3"
              className="w-32 h-32 rounded-full mx-auto mb-4 object-cover"
            />
            <h3 className="text-xl font-semibold">Lê C</h3>
            <p>Thiết kế 3D & Âm thanh</p>
          </div>
        </div>
      </section>
    </PageWrapper>
  );
}
