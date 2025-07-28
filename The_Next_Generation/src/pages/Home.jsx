import PageWrapper from "../components/PageWrapper";
import { motion } from "framer-motion";

export default function Home() {
  return (
    <PageWrapper>
      <section className="text-center py-16 px-6">
        <motion.h1
          className="text-4xl md:text-5xl font-bold mb-6"
          initial={{ opacity: 0, y: -40 }}
          animate={{ opacity: 1, y: 0 }}
          transition={{ duration: 0.8 }}
        >
          The Next Generation
        </motion.h1>
        <motion.p
          className="max-w-xl mx-auto text-lg"
          initial={{ opacity: 0 }}
          animate={{ opacity: 1 }}
          transition={{ delay: 0.5 }}
        >
          Một tựa game indie mang chủ đề chữa lành, nơi bạn sẽ đồng hành cùng
          nhân vật vượt qua ký ức và tổn thương để tìm lại chính mình.
        </motion.p>
      </section>
    </PageWrapper>
  );
}
