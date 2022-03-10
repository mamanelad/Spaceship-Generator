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
                Debug.LogError($"Size must be greater than {MIN_SIZE}");
                topSizeRange.Min = MIN_SIZE;
                topSizeRange.Max = Mathf.Max(topSizeRange.Max, MIN_SIZE);
            }

            if (sidesSizeRange.Min < MIN_SIZE)
            {
                Debug.LogError($"Size must be greater than {MIN_SIZE}");
                sidesSizeRange.Min = MIN_SIZE;
                sidesSizeRange.Max = Mathf.Max(sidesSizeRange.Max, MIN_SIZE);
            }
        }

        public override void Generate(EditableMesh mesh)
        {
            Vector3 Z = new Vector3(0, 0, 0);
            Vector3 A = new Vector3(0, 1, 0);
            Vector3 B = new Vector3(0.4f, 0, 0);
            Vector3 C = new Vector3(0, -0.75f, 0);
            Vector3 E = new Vector3(-0.4f, 0, 0);



            // Vector3 BU = new Vector3(0.4f, 0, -0.2f);
            // Vector3 CU = new Vector3(0, -0.75f, -0.2f);
            // Vector3 EU = new Vector3(-0.4f, 0, -0.2f);
            
            

            Vector3 ZB = new Vector3(0, 0, 0.2f);
            Vector3 AB = new Vector3(0, 1, 0.2f);
            Vector3 BB = new Vector3(0.4f, 0, 0.2f);
            Vector3 CB = new Vector3(0, -0.75f, 0.2f);
            Vector3 EB = new Vector3(-0.4f, 0, 0.2f);


             var temp0Vector3 = new Vector3(0, -0.85f, 0);
            // var temp0Vector3 = new Vector3(0, -0.85f, 0);
            
            Vector3 R1 = temp0Vector3.RotateInDegreesAroundZ(10);
            Vector3 R2 = temp0Vector3.RotateInDegreesAroundZ(20);
            Vector3 R3 = temp0Vector3.RotateInDegreesAroundZ(30);
            Vector3 R4 = temp0Vector3.RotateInDegreesAroundZ(40);
            Vector3 R5 = temp0Vector3.RotateInDegreesAroundZ(50);
            Vector3 R6 = temp0Vector3.RotateInDegreesAroundZ(60);
            Vector3 R7 = temp0Vector3.RotateInDegreesAroundZ(70);
            Vector3 R8 = temp0Vector3.RotateInDegreesAroundZ(80);
            Vector3 R9 = temp0Vector3.RotateInDegreesAroundZ(90);
            Vector3 R10 = temp0Vector3.RotateInDegreesAroundZ(100);
            Vector3 R11 = temp0Vector3.RotateInDegreesAroundZ(110);
            Vector3 R12 = temp0Vector3.RotateInDegreesAroundZ(120);
            Vector3 R13 = temp0Vector3.RotateInDegreesAroundZ(130);
            Vector3 R14 = temp0Vector3.RotateInDegreesAroundZ(140);
            
            Vector3 L1 = temp0Vector3.RotateInDegreesAroundZ(-10);
            Vector3 L2 = temp0Vector3.RotateInDegreesAroundZ(-20);
            Vector3 L3 = temp0Vector3.RotateInDegreesAroundZ(-30);
            Vector3 L4 = temp0Vector3.RotateInDegreesAroundZ(-40);
            Vector3 L5 = temp0Vector3.RotateInDegreesAroundZ(-50);
            Vector3 L6 = temp0Vector3.RotateInDegreesAroundZ(-60);
            Vector3 L7 = temp0Vector3.RotateInDegreesAroundZ(-70);
            Vector3 L8 = temp0Vector3.RotateInDegreesAroundZ(-80);
            Vector3 L9 = temp0Vector3.RotateInDegreesAroundZ(-90);
            Vector3 L10 = temp0Vector3.RotateInDegreesAroundZ(-100);
            Vector3 L11 = temp0Vector3.RotateInDegreesAroundZ(-110);
            Vector3 L12 = temp0Vector3.RotateInDegreesAroundZ(-120);
            Vector3 L13 = temp0Vector3.RotateInDegreesAroundZ(-130);
            Vector3 L14 = temp0Vector3.RotateInDegreesAroundZ(-140);


            temp0Vector3.z += 0.2f;
            Vector3 R1B = temp0Vector3.RotateInDegreesAroundZ(10);
            Vector3 R2B = temp0Vector3.RotateInDegreesAroundZ(20);
            Vector3 R3B = temp0Vector3.RotateInDegreesAroundZ(30);
            Vector3 R4B = temp0Vector3.RotateInDegreesAroundZ(40);
            Vector3 R5B = temp0Vector3.RotateInDegreesAroundZ(50);
            Vector3 R6B = temp0Vector3.RotateInDegreesAroundZ(60);
            Vector3 R7B = temp0Vector3.RotateInDegreesAroundZ(70);
            Vector3 R8B = temp0Vector3.RotateInDegreesAroundZ(80);
            Vector3 R9B = temp0Vector3.RotateInDegreesAroundZ(90);
            Vector3 R10B = temp0Vector3.RotateInDegreesAroundZ(100);
            Vector3 R11B = temp0Vector3.RotateInDegreesAroundZ(110);
            Vector3 R12B = temp0Vector3.RotateInDegreesAroundZ(120);
            Vector3 R13B = temp0Vector3.RotateInDegreesAroundZ(130);
            Vector3 R14B = temp0Vector3.RotateInDegreesAroundZ(140);
            
            Vector3 L1B = temp0Vector3.RotateInDegreesAroundZ(-10);
            Vector3 L2B = temp0Vector3.RotateInDegreesAroundZ(-20);
            Vector3 L3B = temp0Vector3.RotateInDegreesAroundZ(-30);
            Vector3 L4B = temp0Vector3.RotateInDegreesAroundZ(-40);
            Vector3 L5B = temp0Vector3.RotateInDegreesAroundZ(-50);
            Vector3 L6B = temp0Vector3.RotateInDegreesAroundZ(-60);
            Vector3 L7B = temp0Vector3.RotateInDegreesAroundZ(-70);
            Vector3 L8B = temp0Vector3.RotateInDegreesAroundZ(-80);
            Vector3 L9B = temp0Vector3.RotateInDegreesAroundZ(-90);
            Vector3 L10B = temp0Vector3.RotateInDegreesAroundZ(-100);
            Vector3 L11B = temp0Vector3.RotateInDegreesAroundZ(-110);
            Vector3 L12B = temp0Vector3.RotateInDegreesAroundZ(-120);
            Vector3 L13B = temp0Vector3.RotateInDegreesAroundZ(-130);
            Vector3 L14B = temp0Vector3.RotateInDegreesAroundZ(-140);

            
            
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
                
                // //66
                // A,B,C,E,
                // //69
                // BU,CU,EU
                
            };


            // for (int i = 0; i < points.Count; i++)
            // {
            //     points[i] = points[i].RotateInDegreesAroundX(90);
            // }
            

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
                51,36,65,
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
                
            };
            
            
            
            
            
            
            
            
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