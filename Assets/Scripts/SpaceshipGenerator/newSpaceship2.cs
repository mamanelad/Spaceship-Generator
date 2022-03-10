using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Avrahamy.Math;
using Avrahamy.Meshes;
using BitStrap;

namespace SpaceshipGenerator
{
    [CreateAssetMenu(menuName = "Spaceship Generator/ELAD", fileName = "ELADSpaceshipGenerator")]
    public class newSpaceship2 : SpaceshipGenerator
    {
        public const float MIN_SIZE = 0.1f;
        private const int FACE_SIZE = 8;
        private const int LAST_FACE_OFFSET = 8 + 8 + 4;

        [SerializeField] FloatRange topSizeRange;
        [SerializeField] FloatRange sidesSizeRange;
        [SerializeField] bool autoClampToMaxRadius = true;

        protected void OnValidate()
        {
            if (topSizeRange.Min < MIN_SIZE)
            {
                // Debug.LogError($"Size must be greater than {MIN_SIZE}");
                topSizeRange.Min = MIN_SIZE;
                topSizeRange.Max = Mathf.Max(topSizeRange.Max, MIN_SIZE);
            }

            if (sidesSizeRange.Min < MIN_SIZE)
            {
                // Debug.LogError($"Size must be greater than {MIN_SIZE}");
                sidesSizeRange.Min = MIN_SIZE;
                sidesSizeRange.Max = Mathf.Max(sidesSizeRange.Max, MIN_SIZE);
            }
        }

        public override void Generate(EditableMesh mesh)
        {
            //front part
            Vector3 Z = new Vector3(0, 0, 0);
            Vector3 A = new Vector3(0, 1, 0);
            Vector3 B = new Vector3(0.4f, 0, 0);
            Vector3 C = new Vector3(0, -0.75f, 0);
            Vector3 E = new Vector3(-0.4f, 0, 0);

            //back part
            Vector3 ZB = new Vector3(0, 0, 0.2f);
            Vector3 AB = new Vector3(0, 1, 0.2f);
            Vector3 BB = new Vector3(0.4f, 0, 0.2f);
            Vector3 CB = new Vector3(0, -0.75f, 0.2f);
            Vector3 EB = new Vector3(-0.4f, 0, 0.2f);


            var temp0Vector2 = new Vector2(0, -0.85f);

            var temp1Vector2 = temp0Vector2.RotateInDegrees(10);
            var temp2Vector2 = temp0Vector2.RotateInDegrees(20);
            var temp3Vector2 = temp0Vector2.RotateInDegrees(30);
            var temp4Vector2 = temp0Vector2.RotateInDegrees(40);
            var temp5Vector2 = temp0Vector2.RotateInDegrees(50);
            var temp6Vector2 = temp0Vector2.RotateInDegrees(60);
            var temp7Vector2 = temp0Vector2.RotateInDegrees(70);
            var temp8Vector2 = temp0Vector2.RotateInDegrees(80);
            var temp9Vector2 = temp0Vector2.RotateInDegrees(90);
            var temp10Vector2 = temp0Vector2.RotateInDegrees(100);
            var temp11Vector2 = temp0Vector2.RotateInDegrees(110);
            var temp12Vector2 = temp0Vector2.RotateInDegrees(120);
            var temp13Vector2 = temp0Vector2.RotateInDegrees(130);
            var temp14Vector2 = temp0Vector2.RotateInDegrees(140);

            var temp21Vector2 = temp0Vector2.RotateInDegrees(-10);
            var temp22Vector2 = temp0Vector2.RotateInDegrees(-20);
            var temp23Vector2 = temp0Vector2.RotateInDegrees(-30);
            var temp24Vector2 = temp0Vector2.RotateInDegrees(-40);
            var temp25Vector2 = temp0Vector2.RotateInDegrees(-50);
            var temp26Vector2 = temp0Vector2.RotateInDegrees(-60);
            var temp27Vector2 = temp0Vector2.RotateInDegrees(-70);
            var temp28Vector2 = temp0Vector2.RotateInDegrees(-80);
            var temp29Vector2 = temp0Vector2.RotateInDegrees(-90);
            var temp210Vector2 = temp0Vector2.RotateInDegrees(-100);
            var temp211Vector2 = temp0Vector2.RotateInDegrees(-110);
            var temp212Vector2 = temp0Vector2.RotateInDegrees(-120);
            var temp213Vector2 = temp0Vector2.RotateInDegrees(-130);
            var temp214Vector2 = temp0Vector2.RotateInDegrees(-140);


            Vector3 R1 = new Vector3(temp1Vector2.x, temp1Vector2.y, 0);
            Vector3 R2 = new Vector3(temp2Vector2.x, temp2Vector2.y, 0);
            Vector3 R3 = new Vector3(temp3Vector2.x, temp3Vector2.y, 0);
            Vector3 R4 = new Vector3(temp4Vector2.x, temp4Vector2.y, 0);
            Vector3 R5 = new Vector3(temp5Vector2.x, temp5Vector2.y, 0);
            Vector3 R6 = new Vector3(temp6Vector2.x, temp6Vector2.y, 0);
            Vector3 R7 = new Vector3(temp7Vector2.x, temp7Vector2.y, 0);
            Vector3 R8 = new Vector3(temp8Vector2.x, temp8Vector2.y, 0);
            Vector3 R9 = new Vector3(temp9Vector2.x, temp9Vector2.y, 0);
            Vector3 R10 = new Vector3(temp10Vector2.x, temp10Vector2.y, 0);
            Vector3 R11 = new Vector3(temp11Vector2.x, temp11Vector2.y, 0);
            Vector3 R12 = new Vector3(temp12Vector2.x, temp12Vector2.y, 0);
            Vector3 R13 = new Vector3(temp13Vector2.x, temp13Vector2.y, 0);
            Vector3 R14 = new Vector3(temp14Vector2.x, temp14Vector2.y, 0);

            Vector3 L1 = new Vector3(temp21Vector2.x, temp21Vector2.y, 0);
            Vector3 L2 = new Vector3(temp22Vector2.x, temp22Vector2.y, 0);
            Vector3 L3 = new Vector3(temp23Vector2.x, temp23Vector2.y, 0);
            Vector3 L4 = new Vector3(temp24Vector2.x, temp24Vector2.y, 0);
            Vector3 L5 = new Vector3(temp25Vector2.x, temp25Vector2.y, 0);
            Vector3 L6 = new Vector3(temp26Vector2.x, temp26Vector2.y, 0);
            Vector3 L7 = new Vector3(temp27Vector2.x, temp27Vector2.y, 0);
            Vector3 L8 = new Vector3(temp28Vector2.x, temp28Vector2.y, 0);
            Vector3 L9 = new Vector3(temp29Vector2.x, temp29Vector2.y, 0);
            Vector3 L10 = new Vector3(temp210Vector2.x, temp210Vector2.y, 0);
            Vector3 L11 = new Vector3(temp211Vector2.x, temp211Vector2.y, 0);
            Vector3 L12 = new Vector3(temp212Vector2.x, temp212Vector2.y, 0);
            Vector3 L13 = new Vector3(temp213Vector2.x, temp213Vector2.y, 0);
            Vector3 L14 = new Vector3(temp214Vector2.x, temp214Vector2.y, 0);







            Vector3 R1B = new Vector3(temp1Vector2.x, temp1Vector2.y, 0.2f);
            Vector3 R2B = new Vector3(temp2Vector2.x, temp2Vector2.y, 0.2f);
            Vector3 R3B = new Vector3(temp3Vector2.x, temp3Vector2.y, 0.2f);
            Vector3 R4B = new Vector3(temp4Vector2.x, temp4Vector2.y, 0.2f);
            Vector3 R5B = new Vector3(temp5Vector2.x, temp5Vector2.y, 0.2f);
            Vector3 R6B = new Vector3(temp6Vector2.x, temp6Vector2.y, 0.2f);
            Vector3 R7B = new Vector3(temp7Vector2.x, temp7Vector2.y, 0.2f);
            Vector3 R8B = new Vector3(temp8Vector2.x, temp8Vector2.y, 0.2f);
            Vector3 R9B = new Vector3(temp9Vector2.x, temp9Vector2.y, 0.2f);
            Vector3 R10B = new Vector3(temp10Vector2.x, temp10Vector2.y, 0.2f);
            Vector3 R11B = new Vector3(temp11Vector2.x, temp11Vector2.y, 0.2f);
            Vector3 R12B = new Vector3(temp12Vector2.x, temp12Vector2.y, 0.2f);
            Vector3 R13B = new Vector3(temp13Vector2.x, temp13Vector2.y, 0.2f);
            Vector3 R14B = new Vector3(temp14Vector2.x, temp14Vector2.y, 0.2f);

            Vector3 L1B = new Vector3(temp21Vector2.x, temp21Vector2.y, 0.2f);
            Vector3 L2B = new Vector3(temp22Vector2.x, temp22Vector2.y, 0.2f);
            Vector3 L3B = new Vector3(temp23Vector2.x, temp23Vector2.y, 0.2f);
            Vector3 L4B = new Vector3(temp24Vector2.x, temp24Vector2.y, 0.2f);
            Vector3 L5B = new Vector3(temp25Vector2.x, temp25Vector2.y, 0.2f);
            Vector3 L6B = new Vector3(temp26Vector2.x, temp26Vector2.y, 0.2f);
            Vector3 L7B = new Vector3(temp27Vector2.x, temp27Vector2.y, 0.2f);
            Vector3 L8B = new Vector3(temp28Vector2.x, temp28Vector2.y, 0.2f);
            Vector3 L9B = new Vector3(temp29Vector2.x, temp29Vector2.y, 0.2f);
            Vector3 L10B = new Vector3(temp210Vector2.x, temp210Vector2.y, 0.2f);
            Vector3 L11B = new Vector3(temp211Vector2.x, temp211Vector2.y, 0.2f);
            Vector3 L12B = new Vector3(temp212Vector2.x, temp212Vector2.y, 0.2f);
            Vector3 L13B = new Vector3(temp213Vector2.x, temp213Vector2.y, 0.2f);
            Vector3 L14B = new Vector3(temp214Vector2.x, temp214Vector2.y, 0.2f);


            //connections Upper

            //Connection Upper Right + "point name"
            Vector3 CURz = Z;
            Vector3 CURa = A;
            Vector3 CURb = B;
            Vector3 CURc = C;
            Vector3 CUR1 = R1;
            Vector3 CUR2 = R2;
            Vector3 CUR3 = R3;
            Vector3 CUR4 = R4;
            Vector3 CUR5 = R5;
            Vector3 CUR6 = R6;
            Vector3 CUR7 = R7;
            Vector3 CUR8 = R8;
            Vector3 CUR9 = R9;
            Vector3 CUR10 = R10;
            Vector3 CUR11 = R11;
            Vector3 CUR12 = R12;
            Vector3 CUR13 = R13;
            Vector3 CUR14 = R14;

            //Connection Lower Right + "point name"
            Vector3 CLRz = ZB;
            Vector3 CLRa = AB;
            Vector3 CLRb = BB;
            Vector3 CLRc = CB;
            Vector3 CLR1 = R1B;
            Vector3 CLR2 = R2B;
            Vector3 CLR3 = R3B;
            Vector3 CLR4 = R4B;
            Vector3 CLR5 = R5B;
            Vector3 CLR6 = R6B;
            Vector3 CLR7 = R7B;
            Vector3 CLR8 = R8B;
            Vector3 CLR9 = R9B;
            Vector3 CLR10 = R10B;
            Vector3 CLR11 = R11B;
            Vector3 CLR12 = R12B;
            Vector3 CLR13 = R13B;
            Vector3 CLR14 = R14B;

            //Connection Upper Left + "point name"
            Vector3 CULz = Z;
            Vector3 CULa = A;
            Vector3 CULb = B;
            Vector3 CULc = C;
            Vector3 CULe = E;
            Vector3 CUL1 = L1;
            Vector3 CUL2 = L2;
            Vector3 CUL3 = L3;
            Vector3 CUL4 = L4;
            Vector3 CUL5 = L5;
            Vector3 CUL6 = L6;
            Vector3 CUL7 = L7;
            Vector3 CUL8 = L8;
            Vector3 CUL9 = L9;
            Vector3 CUL10 = L10;
            Vector3 CUL11 = L11;
            Vector3 CUL12 = L12;
            Vector3 CUL13 = L13;
            Vector3 CUL14 = L14;

            //Connection Lower LEFT + "point name"
            Vector3 CLLz = ZB;
            Vector3 CLLa = AB;
            Vector3 CLLb = BB;
            Vector3 CLLc = CB;
            Vector3 CLLe = EB;
            Vector3 CLL1 = L1B;
            Vector3 CLL2 = L2B;
            Vector3 CLL3 = L3B;
            Vector3 CLL4 = L4B;
            Vector3 CLL5 = L5B;
            Vector3 CLL6 = L6B;
            Vector3 CLL7 = L7B;
            Vector3 CLL8 = L8B;
            Vector3 CLL9 = L9B;
            Vector3 CLL10 = L10B;
            Vector3 CLL11 = L11B;
            Vector3 CLL12 = L12B;
            Vector3 CLL13 = L13B;
            Vector3 CLL14 = L14B;

            var points = new List<Vector3>(100)
            {
                Z, A, B, C,
                //4
                R1, R2, R3, R4, R5, R6, R7, R8, R9, R10, R11, R12, R13, R14,
                //18
                L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12, L13, L14,
                //32
                E,
                //33
                ZB, AB, BB, CB,
                //37
                R1B, R2B, R3B, R4B, R5B, R6B, R7B, R8B, R9B, R10B, R11B, R12B, R13B, R14B,
                //51
                L1B, L2B, L3B, L4B, L5B, L6B, L7B, L8B, L9B, L10B, L11B, L12B, L13B, L14B,
                //65
                EB,

                //Connections points upper right
                //
                CURa, CURb, CURc, CURz,
                //
                CUR1, CUR2, CUR3, CUR4, CUR5, CUR6, CUR7, CUR8, CUR9, CUR10, CUR11, CUR12, CUR13, CUR14,


                //Connections points lower right
                //
                CLRa, CLRb, CLRc, CLRz,
                //
                CLR1, CLR2, CLR3, CLR4, CLR5, CLR6, CLR7, CLR8, CLR9, CLR10, CLR11, CLR12, CLR13, CLR14,

                //Connections points upper LEFT
                //
                CULa, CULb, CULc, CULz, CULe,
                //
                CUL1, CUL2, CUL3, CUL4, CUL5, CUL6, CUL7, CUL8, CUL9, CUL10, CUL11, CUL12, CUL13, CUL14,


                //Connections points lower LEFT
                //
                CLLa, CLLb, CLLc, CLLz, CLLe,
                //
                CLL1, CLL2, CLL3, CLL4, CLL5, CLL6, CLL7, CLL8, CLL9, CLL10, CLL11, CLL12, CLL13, CLL14




            };

            var triangles = new[]
            {
                // up 
                3, 1, 2,
                4, 3, 0,
                5, 4, 0,
                6, 5, 0,
                7, 6, 0,
                8, 7, 0,
                9, 8, 0,
                10, 9, 0,
                11, 10, 0,
                12, 11, 0,
                13, 12, 0,
                14, 13, 0,
                15, 14, 0,
                16, 15, 0,
                17, 16, 0,

                //14
                33, 41, 40,
                33, 42, 41,
                33, 43, 42,
                33, 44, 43,
                33, 45, 44,
                33, 46, 45,


                0, 17, 18,
                0, 18, 19,
                0, 19, 20,
                0, 20, 21,
                0, 21, 22,
                0, 22, 23,
                0, 23, 24,
                0, 24, 25,
                0, 25, 26,
                0, 26, 27,
                0, 27, 28,
                0, 28, 29,
                0, 29, 30,
                0, 30, 31,

                0, 3, 18,
                3, 32, 1,

                // Down
                //left side
                36, 35, 34,
                37, 33, 36,
                38, 33, 37,
                39, 33, 38,
                40, 33, 39,
                41, 33, 40,
                42, 33, 41,
                43, 33, 42,
                44, 33, 43,
                45, 33, 44,
                46, 33, 45,
                47, 33, 46,
                48, 33, 47,
                49, 33, 48,
                50, 33, 49,

                //right side
                36, 34, 65,
                51, 36, 33,

                52, 51, 33,
                53, 52, 33,
                54, 53, 33,
                55, 54, 33,
                56, 55, 33,
                57, 56, 33,
                58, 57, 33,
                59, 58, 33,
                60, 59, 33,
                61, 60, 33,
                62, 61, 33,
                63, 62, 33,
                64, 63, 33,

                // Down
                //left side
                36, 35, 34,
                37, 33, 36,
                38, 33, 37,
                39, 33, 38,
                40, 33, 39,
                41, 33, 40,
                42, 33, 41,
                43, 33, 42,
                44, 33, 43,
                45, 33, 44,
                46, 33, 45,
                47, 33, 46,
                48, 33, 47,
                49, 33, 48,
                50, 33, 49,

                //right side down
                36, 34, 65,
                51, 36, 33,

                52, 51, 33,
                53, 52, 33,
                54, 53, 33,
                55, 54, 33,
                56, 55, 33,
                57, 56, 33,
                58, 57, 33,
                59, 58, 33,
                60, 59, 33,
                61, 60, 33,
                62, 61, 33,
                63, 62, 33,
                64, 63, 33,

                //connections
                points.IndexOf(CURa), points.IndexOf(CLRa), points.IndexOf(CLRb),
                points.IndexOf(CURa), points.IndexOf(CLRb), points.IndexOf(CURb),

                points.IndexOf(CURz), points.IndexOf(CLRz), points.IndexOf(CUR14),
                points.IndexOf(CUR14), points.IndexOf(CLRz), points.IndexOf(CLR14),

                points.IndexOf(CUR13), points.IndexOf(CUR14), points.IndexOf(CLR14),
                points.IndexOf(CUR13), points.IndexOf(CLR14), points.IndexOf(CLR13),

                points.IndexOf(CUR12), points.IndexOf(CUR13), points.IndexOf(CLR13),
                points.IndexOf(CUR12), points.IndexOf(CLR13), points.IndexOf(CLR12),

                points.IndexOf(CUR11), points.IndexOf(CUR12), points.IndexOf(CLR12),
                points.IndexOf(CUR11), points.IndexOf(CLR12), points.IndexOf(CLR11),

                points.IndexOf(CUR10), points.IndexOf(CUR11), points.IndexOf(CLR11),
                points.IndexOf(CUR10), points.IndexOf(CLR11), points.IndexOf(CLR10),

                points.IndexOf(CUR9), points.IndexOf(CUR10), points.IndexOf(CLR10),
                points.IndexOf(CUR9), points.IndexOf(CLR10), points.IndexOf(CLR9),

                points.IndexOf(CUR8), points.IndexOf(CUR9), points.IndexOf(CLR9),
                points.IndexOf(CUR8), points.IndexOf(CLR9), points.IndexOf(CLR8),

                points.IndexOf(CUR7), points.IndexOf(CUR8), points.IndexOf(CLR8),
                points.IndexOf(CUR7), points.IndexOf(CLR8), points.IndexOf(CLR7),

                points.IndexOf(CUR6), points.IndexOf(CUR7), points.IndexOf(CLR7),
                points.IndexOf(CUR6), points.IndexOf(CLR7), points.IndexOf(CLR6),

                points.IndexOf(CUR5), points.IndexOf(CUR6), points.IndexOf(CLR6),
                points.IndexOf(CUR5), points.IndexOf(CLR6), points.IndexOf(CLR5),

                points.IndexOf(CUR4), points.IndexOf(CUR5), points.IndexOf(CLR5),
                points.IndexOf(CUR4), points.IndexOf(CLR5), points.IndexOf(CLR4),

                points.IndexOf(CUR3), points.IndexOf(CUR4), points.IndexOf(CLR4),
                points.IndexOf(CUR3), points.IndexOf(CLR4), points.IndexOf(CLR3),

                points.IndexOf(CUR2), points.IndexOf(CUR3), points.IndexOf(CLR3),
                points.IndexOf(CUR2), points.IndexOf(CLR3), points.IndexOf(CLR2),

                points.IndexOf(CUR1), points.IndexOf(CUR2), points.IndexOf(CLR2),
                points.IndexOf(CUR1), points.IndexOf(CLR2), points.IndexOf(CLR1),

                points.IndexOf(CUR1), points.IndexOf(CLR1), points.IndexOf(CURc),
                points.IndexOf(CLR1), points.IndexOf(CLRc), points.IndexOf(CURc),


                //left
                //321
                points.IndexOf(CULa), points.IndexOf(CLLa), points.IndexOf(CLLe),
                points.IndexOf(CULa), points.IndexOf(CLLe), points.IndexOf(CULe),

                points.IndexOf(CULz), points.IndexOf(CLLz), points.IndexOf(CUL14),
                points.IndexOf(CUL14), points.IndexOf(CLLz), points.IndexOf(CLL14),

                points.IndexOf(CUL13), points.IndexOf(CUL14), points.IndexOf(CLL14),
                points.IndexOf(CUL13), points.IndexOf(CLL14), points.IndexOf(CLL13),

                points.IndexOf(CUL12), points.IndexOf(CUL13), points.IndexOf(CLL13),
                points.IndexOf(CUL12), points.IndexOf(CLL13), points.IndexOf(CLL12),

                points.IndexOf(CUL11), points.IndexOf(CUL12), points.IndexOf(CLL12),
                points.IndexOf(CUL11), points.IndexOf(CLL12), points.IndexOf(CLL11),

                points.IndexOf(CUL10), points.IndexOf(CUL11), points.IndexOf(CLL11),
                points.IndexOf(CUL10), points.IndexOf(CLL11), points.IndexOf(CLL10),

                points.IndexOf(CUL9), points.IndexOf(CUL10), points.IndexOf(CLL10),
                points.IndexOf(CUL9), points.IndexOf(CLL10), points.IndexOf(CLL9),

                points.IndexOf(CUL8), points.IndexOf(CUL9), points.IndexOf(CLL9),
                points.IndexOf(CUL8), points.IndexOf(CLL9), points.IndexOf(CLL8),

                points.IndexOf(CUL7), points.IndexOf(CUL8), points.IndexOf(CLL8),
                points.IndexOf(CUL7), points.IndexOf(CLL8), points.IndexOf(CLL7),

                points.IndexOf(CUL6), points.IndexOf(CUL7), points.IndexOf(CLL7),
                points.IndexOf(CUL6), points.IndexOf(CLL7), points.IndexOf(CLL6),

                points.IndexOf(CUL5), points.IndexOf(CUL6), points.IndexOf(CLL6),
                points.IndexOf(CUL5), points.IndexOf(CLL6), points.IndexOf(CLL5),

                points.IndexOf(CUL4), points.IndexOf(CUL5), points.IndexOf(CLL5),
                points.IndexOf(CUL4), points.IndexOf(CLL5), points.IndexOf(CLL4),

                points.IndexOf(CUL3), points.IndexOf(CUL4), points.IndexOf(CLL4),
                points.IndexOf(CUL3), points.IndexOf(CLL4), points.IndexOf(CLL3),

                points.IndexOf(CUL2), points.IndexOf(CUL3), points.IndexOf(CLL3),
                points.IndexOf(CUL2), points.IndexOf(CLL3), points.IndexOf(CLL2),

                points.IndexOf(CUL1), points.IndexOf(CUL2), points.IndexOf(CLL2),
                points.IndexOf(CUL1), points.IndexOf(CLL2), points.IndexOf(CLL1),

                points.IndexOf(CUL1), points.IndexOf(CLL1), points.IndexOf(CULc),
                points.IndexOf(CLL1), points.IndexOf(CLLc), points.IndexOf(CULc),




            };
            FlipTriangles(triangles, 321, triangles.Length - 1);


            //ADD 33 AND REPLACE TGE TWO LAST 




            // var topHalfSize = topSizeRange.RandomInside() / 2;
            // var sidesHalfSize = sidesSizeRange.RandomInside() / 2;
            //
            // // The first face.
            // const int POINTS_COUNT = 4 * 2 + 4 * 2 * 2;
            // var points = new List<Vector3>(POINTS_COUNT) {
            //     new Vector3(sidesHalfSize, topHalfSize, -MAX_RADIUS),
            //     new Vector3(sidesHalfSize, -topHalfSize, -MAX_RADIUS),
            //     new Vector3(-sidesHalfSize, -topHalfSize, -MAX_RADIUS),
            //     new Vector3(-sidesHalfSize, topHalfSize, -MAX_RADIUS),
            // };
            // var uvs = new List<Vector2>(POINTS_COUNT) {
            //     new Vector2(1f, 0.25f),
            //     new Vector2(1f, 0f),
            //     new Vector2(0.75f, 0f),
            //     new Vector2(0.75f, 0.25f),
            // };
            //
            // // Duplicate the first face and split its vertices so they can create
            // // hard edges.
            // points.Add(points[0]);
            // uvs.Add(new Vector2(0f, 0.25f));
            // for (int i = 1; i < 4; i++) {
            //     points.Add(points[i]);
            //     points.Add(points[i]);
            //     var uv = new Vector2(0.25f * i, 0.25f);
            //     uvs.Add(uv);
            //     uvs.Add(uv);
            // }
            // points.Add(points[0]);
            // uvs.Add(new Vector2(1f, 0.25f));
            //
            // // Create the other end of the top and side faces.
            // for (int i = 4; i < 4 + 8; i++) {
            //     var point = points[i];
            //     point.z = MAX_RADIUS;
            //     points.Add(point);
            //     var uv = uvs[i];
            //     uv.y = 0.75f;
            //     uvs.Add(uv);
            // }
            //
            // // Add the last face.
            // for (int i = 0; i < 4; i++) {
            //     var point = points[i];
            //     point.z = MAX_RADIUS;
            //     points.Add(point);
            //     var uv = uvs[i];
            //     uv.y = 1f - uv.y;
            //     uvs.Add(uv);
            // }
            //
            // // There are 4 faces, each face has 2 triangles and each triangle has
            // // the indices of 3 vertices.
            // var triangles = new [] {
            //     // First face.
            //     0, 1, 3,
            //     1, 2, 3,
            //     // Right side.
            //     5, 4, 5 + FACE_SIZE,
            //     4, 4 + FACE_SIZE, 5 + FACE_SIZE,
            //     // Bottom side.
            //     7, 6, 7 + FACE_SIZE,
            //     6, 6 + FACE_SIZE, 7 + FACE_SIZE,
            //     // Left side.
            //     9, 8, 9 + FACE_SIZE,
            //     8, 8 + FACE_SIZE, 9 + FACE_SIZE,
            //     // Top side.
            //     11, 10, 11 + FACE_SIZE,
            //     10, 10 + FACE_SIZE, 11 + FACE_SIZE,
            //     // Last face (flipped compared to the first face).
            //     1 + LAST_FACE_OFFSET, 0 + LAST_FACE_OFFSET, 3 + LAST_FACE_OFFSET,
            //     2 + LAST_FACE_OFFSET, 1 + LAST_FACE_OFFSET, 3 + LAST_FACE_OFFSET,
            // };
            //
            // if (autoClampToMaxRadius) {
            //     ClampToRadius(points, MAX_RADIUS);
            // }
            //
            mesh.SetPoints(points.ToArray(), triangles);
            //
            // mesh.Mesh.uv = uvs.ToArray();
        }
    }
}

