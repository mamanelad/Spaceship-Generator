using UnityEngine;
using System.Collections.Generic;
using Avrahamy.Math;
using Avrahamy.Meshes;
using BitStrap;
using UnityEngine.UIElements;

namespace SpaceshipGenerator
{
    [CreateAssetMenu(menuName = "Spaceship Generator/ELAD", fileName = "ELADSpaceshipGenerator")]
    public class newSpachip : SpaceshipGenerator
    {   private float frontShipRand;
        private float backShipRand;
        private float sideShipRand;
        private float circleVectorLenRand;
        private float cockpitHeightRand;
        private float shipDepthRand;
        private float angleRand;

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
        private void RandomSizeMaker()
        {
            frontShipRand = Random.Range(0.3f, MAX_RADIUS);
            backShipRand = Random.Range(0, MAX_RADIUS);
            sideShipRand = Random.Range(0.2f, 0.6f);
            circleVectorLenRand = Random.Range(0.6f, MAX_RADIUS);
            cockpitHeightRand = Random.Range(0.1f, 0.5f);
            shipDepthRand = Random.Range(0.05f, 0.4f);
            angleRand = Random.Range(5, 10);
        }

        public override void Generate(EditableMesh mesh)
        {
            RandomSizeMaker();
            //Top vertex
            var centerV = new Vector3(0, 0, 0);
            var frontV = new Vector3(0, frontShipRand, 0);
            var rightV = new Vector3(sideShipRand, 0, 0);
            var backV = new Vector3(0, -backShipRand, 0);
            var leftV = new Vector3(-sideShipRand, 0, 0);

            //Cockpit vertex
            var centerVUp = new Vector3(0, 0, -cockpitHeightRand);
            var backVUp = new Vector3(0, -backShipRand, -cockpitHeightRand);
            var rightVUp = new Vector3(sideShipRand, 0, -cockpitHeightRand);
            var leftVUp = new Vector3(-sideShipRand, 0, -cockpitHeightRand);

            //Bottom vertex
            var centerVDown = new Vector3(0, 0, shipDepthRand);
            var frontVDown = new Vector3(0, frontShipRand, shipDepthRand);
            var rightVDown = new Vector3(sideShipRand, 0, shipDepthRand);
            var backVDown = new Vector3(0, -backShipRand, shipDepthRand);
            var leftVDown = new Vector3(-sideShipRand, 0, shipDepthRand);

            //Top 
            var circleMakeV = new Vector3(0, -circleVectorLenRand, 0);
            Vector3 R1 = circleMakeV.RotateInDegreesAroundZ(angleRand);
            Vector3 R2 = circleMakeV.RotateInDegreesAroundZ(2 * angleRand);
            Vector3 R3 = circleMakeV.RotateInDegreesAroundZ(3 * angleRand);
            Vector3 R4 = circleMakeV.RotateInDegreesAroundZ(4 * angleRand);
            Vector3 R5 = circleMakeV.RotateInDegreesAroundZ(5 * angleRand);
            Vector3 R6 = circleMakeV.RotateInDegreesAroundZ(6 * angleRand);
            Vector3 R7 = circleMakeV.RotateInDegreesAroundZ(7 * angleRand);
            Vector3 R8 = circleMakeV.RotateInDegreesAroundZ(8 * angleRand);
            Vector3 R9 = circleMakeV.RotateInDegreesAroundZ(9 * angleRand);
            Vector3 R10 = circleMakeV.RotateInDegreesAroundZ(10 * angleRand);
            Vector3 R11 = circleMakeV.RotateInDegreesAroundZ(11 * angleRand);
            Vector3 R12 = circleMakeV.RotateInDegreesAroundZ(12 * angleRand);
            Vector3 R13 = circleMakeV.RotateInDegreesAroundZ(13 * angleRand);
            Vector3 R14 = circleMakeV.RotateInDegreesAroundZ(14 * angleRand);

            Vector3 L1 = circleMakeV.RotateInDegreesAroundZ(-1 * angleRand);
            Vector3 L2 = circleMakeV.RotateInDegreesAroundZ(-2 * angleRand);
            Vector3 L3 = circleMakeV.RotateInDegreesAroundZ(-3 * angleRand);
            Vector3 L4 = circleMakeV.RotateInDegreesAroundZ(-4 * angleRand);
            Vector3 L5 = circleMakeV.RotateInDegreesAroundZ(-5 * angleRand);
            Vector3 L6 = circleMakeV.RotateInDegreesAroundZ(-6 * angleRand);
            Vector3 L7 = circleMakeV.RotateInDegreesAroundZ(-7 * angleRand);
            Vector3 L8 = circleMakeV.RotateInDegreesAroundZ(-8 * angleRand);
            Vector3 L9 = circleMakeV.RotateInDegreesAroundZ(-9 * angleRand);
            Vector3 L10 = circleMakeV.RotateInDegreesAroundZ(-10 * angleRand);
            Vector3 L11 = circleMakeV.RotateInDegreesAroundZ(-11 * angleRand);
            Vector3 L12 = circleMakeV.RotateInDegreesAroundZ(-12 * angleRand);
            Vector3 L13 = circleMakeV.RotateInDegreesAroundZ(-13 * angleRand);
            Vector3 L14 = circleMakeV.RotateInDegreesAroundZ(-14 * angleRand);


            circleMakeV.z += shipDepthRand;
            Vector3 R1B = circleMakeV.RotateInDegreesAroundZ(1 * angleRand);
            Vector3 R2B = circleMakeV.RotateInDegreesAroundZ(2 * angleRand);
            Vector3 R3B = circleMakeV.RotateInDegreesAroundZ(3 * angleRand);
            Vector3 R4B = circleMakeV.RotateInDegreesAroundZ(4 * angleRand);
            Vector3 R5B = circleMakeV.RotateInDegreesAroundZ(5 * angleRand);
            Vector3 R6B = circleMakeV.RotateInDegreesAroundZ(6 * angleRand);
            Vector3 R7B = circleMakeV.RotateInDegreesAroundZ(7 * angleRand);
            Vector3 R8B = circleMakeV.RotateInDegreesAroundZ(8 * angleRand);
            Vector3 R9B = circleMakeV.RotateInDegreesAroundZ(9 * angleRand);
            Vector3 R10B = circleMakeV.RotateInDegreesAroundZ(10 * angleRand);
            Vector3 R11B = circleMakeV.RotateInDegreesAroundZ(11 * angleRand);
            Vector3 R12B = circleMakeV.RotateInDegreesAroundZ(12 * angleRand);
            Vector3 R13B = circleMakeV.RotateInDegreesAroundZ(13 * angleRand);
            Vector3 R14B = circleMakeV.RotateInDegreesAroundZ(14 * angleRand);

            Vector3 L1B = circleMakeV.RotateInDegreesAroundZ(-1 * angleRand);
            Vector3 L2B = circleMakeV.RotateInDegreesAroundZ(-2 * angleRand);
            Vector3 L3B = circleMakeV.RotateInDegreesAroundZ(-3 * angleRand);
            Vector3 L4B = circleMakeV.RotateInDegreesAroundZ(-4 * angleRand);
            Vector3 L5B = circleMakeV.RotateInDegreesAroundZ(-5 * angleRand);
            Vector3 L6B = circleMakeV.RotateInDegreesAroundZ(-6 * angleRand);
            Vector3 L7B = circleMakeV.RotateInDegreesAroundZ(-7 * angleRand);
            Vector3 L8B = circleMakeV.RotateInDegreesAroundZ(-8 * angleRand);
            Vector3 L9B = circleMakeV.RotateInDegreesAroundZ(-9 * angleRand);
            Vector3 L10B = circleMakeV.RotateInDegreesAroundZ(-10 * angleRand);
            Vector3 L11B = circleMakeV.RotateInDegreesAroundZ(-11 * angleRand);
            Vector3 L12B = circleMakeV.RotateInDegreesAroundZ(-12 * angleRand);
            Vector3 L13B = circleMakeV.RotateInDegreesAroundZ(-13 * angleRand);
            Vector3 L14B = circleMakeV.RotateInDegreesAroundZ(-14 * angleRand);

            //Connection Upper Right + "point name"
            Vector3 CURz = centerV;
            Vector3 CURa = frontV;
            Vector3 CURb = rightV;
            Vector3 CURc = backV;
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
            Vector3 CLRz = centerVDown;
            Vector3 CLRa = frontVDown;
            Vector3 CLRb = rightVDown;
            Vector3 CLRc = backVDown;
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
            Vector3 CULz = centerV;
            Vector3 CULa = frontV;
            Vector3 CULb = rightV;
            Vector3 CULc = backV;
            Vector3 CULe = leftV;
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
            Vector3 CLLz = centerVDown;
            Vector3 CLLa = frontVDown;
            Vector3 CLLb = rightVDown;
            Vector3 CLLc = backVDown;
            Vector3 CLLe = leftVDown;
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
                centerV, frontV, rightV, backV,
                //4
                R1, R2, R3, R4, R5, R6, R7, R8, R9, R10, R11, R12, R13, R14,
                //18
                L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12, L13, L14,
                //32
                leftV,
                //33
                centerVDown, frontVDown, rightVDown, backVDown,
                //37
                R1B, R2B, R3B, R4B, R5B, R6B, R7B, R8B, R9B, R10B, R11B, R12B, R13B, R14B,
                //51
                L1B, L2B, L3B, L4B, L5B, L6B, L7B, L8B, L9B, L10B, L11B, L12B, L13B, L14B,
                //65
                leftVDown,

                //66
                frontV, rightV, backV, leftV,
                //70
                rightVUp, backVUp, leftVUp, centerVUp,
                //74,75
                rightVUp, leftVUp,

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
            
            var uvs = new List<Vector2>();
            addDiscFaceUvs(uvs); //add front face 0-32
            addDiscFaceUvs(uvs); //add back face 33- 65


            //cockpit
            //A'-E' 66-69
            uvs.Add(new Vector2(.5f, .5f)); //A' redundant ##
            uvs.Add(new Vector2(0, .7f)); //B'
            uvs.Add(new Vector2(0, 0.5f)); //C'
            uvs.Add(new Vector2(0, 0.3f)); //E'

            //BU - ZU 70 - 75
            uvs.Add(new Vector2(.25f, .7f)); //BU
            uvs.Add(new Vector2(0, .5f)); //CU redundant##
            uvs.Add(new Vector2(.25f, .3f)); //EU
            uvs.Add(new Vector2(.25f, 0.5f)); //ZU redundant ##
            uvs.Add(new Vector2(.25f, .7f)); //BU'
            uvs.Add(new Vector2(.25f, .3f)); //EU'


            //connections 
            addRightConnectionsUvs(uvs); //right
            addRightConnectionsUvs(uvs); //left
            uvs.Add(new Vector2(.75f, .15f)); // CULe
            uvs.Add(new Vector2(.75f, 0)); // CLLe




            var triangles = new[]
            {
                //up
                //kite-shape
                3, 1, 2,
                3, 32, 1,
                //right side
                4, 3, 2,
                5, 4, 2,
                6, 5, 2,
                7, 6, 2,
                8, 7, 2,
                9, 8, 2,
                10, 9, 2,
                11, 10, 2,
                12, 11, 2,
                13, 12, 2,
                14, 13, 2,
                15, 14, 2,
                16, 15, 2,
                17, 16, 2,
                //left side
                32, 3, 18,
                32, 18, 19,
                32, 19, 20,
                32, 20, 21,
                32, 21, 22,
                32, 22, 23,
                32, 23, 24,
                32, 24, 25,
                32, 25, 26,
                32, 26, 27,
                32, 27, 28,
                32, 28, 29,
                32, 29, 30,
                32, 30, 31,


                // Down
                //kite-shape
                36, 35, 34,
                36, 34, 65,
                //  //left side
                37, 35, 36,
                38, 35, 37,
                39, 35, 38,
                40, 35, 39,
                41, 35, 40,
                42, 35, 41,
                43, 35, 42,
                44, 35, 43,
                45, 35, 44,
                46, 35, 45,
                47, 35, 46,
                48, 35, 47,
                49, 35, 48,
                50, 35, 49,

                //right side
                51, 36, 65,
                52, 51, 65,
                53, 52, 65,
                54, 53, 65,
                55, 54, 65,
                56, 55, 65,
                57, 56, 65,
                58, 57, 65,
                59, 58, 65,
                60, 59, 65,
                61, 60, 65,
                62, 61, 65,
                63, 62, 65,
                64, 63, 65,

                //connections
                points.IndexOf(CURa), points.IndexOf(CLRa), points.IndexOf(CLRb),
                points.IndexOf(CURa), points.IndexOf(CLRb), points.IndexOf(CURb),

                points.IndexOf(CURb), points.IndexOf(CLRb), points.IndexOf(CUR14),
                points.IndexOf(CUR14), points.IndexOf(CLRb), points.IndexOf(CLR14),

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
                //321?
                points.IndexOf(CULa), points.IndexOf(CLLa), points.IndexOf(CLLe),
                points.IndexOf(CULa), points.IndexOf(CLLe), points.IndexOf(CULe),

                points.IndexOf(CULe), points.IndexOf(CLLe), points.IndexOf(CUL14),
                points.IndexOf(CUL14), points.IndexOf(CLLe), points.IndexOf(CLL14),

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

                //Cockpit
                70, 2, 1,
                72, 1, 32,
                74, 1, 75,

                68, 67, 70,
                68, 69, 72,
                68, 75, 74
            };

            FlipTriangles(triangles, 276, triangles.Length - 7);


            for (int i = 0; i < points.Count; i++)
            {
                points[i] = points[i].RotateInDegreesAroundX(90);
            }

            mesh.SetPoints(points.ToArray(), triangles);
            //

            mesh.Mesh.uv = uvs.ToArray();
        }

        private static void addRightConnectionsUvs(List<Vector2> uvs)
        {
            uvs.Add(new Vector2(1f, .15f)); // CURa
            uvs.Add(new Vector2(.75f, .15f)); // CURb
            uvs.Add(new Vector2(1f, 0f)); // CURc 
            uvs.Add(new Vector2(1f, .15f)); // CURz redundant ##

            for (int i = 1; i < 15; i++) // CUR1-CUR14
            {
                if (i % 3 == 0)
                {
                    uvs.Add(new Vector2(1f, 0f)); // Like CLRa
                }

                if (i % 3 == 1)
                {
                    uvs.Add(new Vector2(.75f, .0f)); //LIKE CLRb
                }

                if (i % 3 == 2)
                {
                    uvs.Add(new Vector2(1f, .15f)); // Like CURa
                }
            }

            uvs.Add(new Vector2(1f, 0f)); // CLRa 
            uvs.Add(new Vector2(.75f, .0f)); //CLRb
            uvs.Add(new Vector2(.75f, .0f)); // CLRc
            uvs.Add(new Vector2(1f, .15f)); // CLRz redundant ##

            for (int i = 1; i < 15; i++) // CLR1-CLR14
            {
                if (i % 3 == 0)
                {
                    uvs.Add(new Vector2(.75f, .0f));
                }

                if (i % 3 == 1)
                {
                    uvs.Add(new Vector2(1f, .15f));
                }

                if (i % 3 == 2)
                {
                    uvs.Add(new Vector2(1f, 0f)); // Clr14 like Cur12
                }
            }
        }

        private static void addDiscFaceUvs(List<Vector2> uvs)
        {
            uvs.Add(new Vector2(0.25f, .5f)); //Z
            uvs.Add(new Vector2(.5f, .5f)); //A
            uvs.Add(new Vector2(.75f, 0.7f)); //B
            uvs.Add(new Vector2(1, .5f)); //C

            //R1-R14
            for (int i = 1; i < 15; i++)
            {
                if (i % 2 == 0) //like C
                {
                    uvs.Add(new Vector2(1, .5f));
                }
                else // like A
                {
                    uvs.Add(new Vector2(.5f, .5f));
                }
            }

            //L1-L14
            for (int i = 1; i < 15; i++)
            {
                if (i % 2 == 0) //like C
                {
                    uvs.Add(new Vector2(1, .5f));
                }
                else // like A
                {
                    uvs.Add(new Vector2(.5f, .5f));
                }
            }

            uvs.Add(new Vector2(.75f, 0.3f)); //E=B
        }
    }
}