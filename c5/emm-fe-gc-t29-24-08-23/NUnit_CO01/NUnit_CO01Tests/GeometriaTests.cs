using NUnit_CO01;

namespace NUnit_CO01Tests;

public class NUnit_CO01Tests
{
    [TestFixture]
    public class GeometriaTests
    {

        private Geometria _geometria;

        [SetUp]
        public void Setup()
        {
            _geometria = new Geometria();
        }

        [Test]
        public void TestAreaCuadrado()
        {
            int area = _geometria.areacuadrado(4);
            Assert.That(area, Is.EqualTo(16));
        }

        [Test]
        public void TestAreaCirculo()
        {
            double area = _geometria.areaCirculo(5);
            Assert.That(area, Is.EqualTo(78.53981633974483).Within(0.001));
        }

        [Test]
        public void TestAreaTriangulo()
        {
            int area = _geometria.areatriangulo(3, 6);
            Assert.That(area, Is.EqualTo(9));
        }

        [Test]
        public void TestAreaRectangulo()
        {
            int area = _geometria.arearectangulo(4, 7);
            Assert.That(area, Is.EqualTo(28));
        }

        [Test]
        public void TestAreaPentagono()
        {
            int area = _geometria.areapentagono(5, 6);
            Assert.That(area, Is.EqualTo(15));
        }

        [Test]
        public void TestAreaRombo()
        {
            int area = _geometria.arearombo(8, 6);
            Assert.That(area, Is.EqualTo(24));
        }

        [Test]
        public void TestAreaRomboide()
        {
            int area = _geometria.arearomboide(5, 10);
            Assert.That(area, Is.EqualTo(50));
        }

        [Test]
        public void TestAreaTrapecio()
        {
            int area = _geometria.areatrapecio(10, 6, 8);
            Assert.That(area, Is.EqualTo(64));
        }

        [Test]
        public void TestFiguraDefault()
        {
            string figura = _geometria.figura(0);
            Assert.That(figura, Is.EqualTo("Default"));
        }

        [Test]
        public void TestFiguraCuadrado()
        {
            string figura = _geometria.figura(1);
            Assert.That(figura, Is.EqualTo("cuadrado"));
        }

        [Test]
        public void TestFiguraCirculo()
        {
            string figura = _geometria.figura(2);
            Assert.That(figura, Is.EqualTo("Circulo"));
        }

        [Test]
        public void TestFiguraTriangulo()
        {
            string figura = _geometria.figura(3);
            Assert.That(figura, Is.EqualTo("Triangulo"));
        }

        [Test]
        public void TestFiguraRectangulo()
        {
            string figura = _geometria.figura(4);
            Assert.That(figura, Is.EqualTo("Rectangulo"));
        }

        [Test]
        public void TestFiguraPentagono()
        {
            string figura = _geometria.figura(5);
            Assert.That(figura, Is.EqualTo("Pentagono"));
        }

        [Test]
        public void TestFiguraRombo()
        {
            string figura = _geometria.figura(6);
            Assert.That(figura, Is.EqualTo("Rombo"));
        }

        [Test]
        public void TestFiguraRomboide()
        {
            string figura = _geometria.figura(7);
            Assert.That(figura, Is.EqualTo("Romboide"));
        }

        [Test]
        public void TestFiguraTrapecio()
        {
            string figura = _geometria.figura(8);
            Assert.That(figura, Is.EqualTo("Trapecio"));
        }

        [Test]
        public void TestGetId()
        {
            int id = _geometria.getId();
            Assert.That(id, Is.EqualTo(9));
        }

        [Test]
        public void TestSetId()
        {
            _geometria.setId(10);
            int id = _geometria.getId();
            Assert.That(id, Is.EqualTo(10));
        }

        [Test]
        public void TestGetNom()
        {
            string nom = _geometria.getNom();
            Assert.That(nom, Is.EqualTo("Default"));
        }

        [Test]
        public void TestSetNom()
        {
            _geometria.setNom("NuevoNom");
            string nom = _geometria.getNom();
            Assert.That(nom, Is.EqualTo("NuevoNom"));
        }

        [Test]
        public void TestGetArea()
        {
            double area = _geometria.getArea();
            Assert.That(area, Is.EqualTo(0));
        }

        [Test]
        public void TestSetArea()
        {
            _geometria.setArea(25.5);
            double area = _geometria.getArea();
            Assert.That(area, Is.EqualTo(25.5).Within(0.00001));
        }

        [Test]
        public void TestAreaCuadrado_LadoCero()
        {
            int area = _geometria.areacuadrado(0);
            Assert.That(area, Is.EqualTo(0));
        }

        [Test]
        public void TestAreaCirculo_RadioCero()
        {
            double area = _geometria.areaCirculo(0);
            Assert.That(area, Is.EqualTo(0));
        }

        [Test]
        public void TestAreaTriangulo_BaseAlturaCero()
        {
            int area = _geometria.areatriangulo(0, 5);
            Assert.That(area, Is.EqualTo(0));
        }

        [Test]
        public void TestAreaRectangulo_BaseAlturaCero()
        {
            int area = _geometria.arearectangulo(0, 8);
            Assert.That(area, Is.EqualTo(0));
        }

        [Test]
        public void TestFiguraCodigoInvalido()
        {
            string figura = _geometria.figura(9);
            Assert.That(figura, Is.EqualTo("Default"));
        }

        [Test]
        public void TestGetSetNom()
        {
            _geometria.setNom("NuevoNom");
            string nom = _geometria.getNom();
            Assert.That(nom, Is.EqualTo("NuevoNom"));
        }

        [Test]
        public void TestSetGetArea()
        {
            _geometria.setArea(42.0);
            double area = _geometria.getArea();
            Assert.That(area, Is.EqualTo(42.0).Within(0.00001));
        }
    }
}

