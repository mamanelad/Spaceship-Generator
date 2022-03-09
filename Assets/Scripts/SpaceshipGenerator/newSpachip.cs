using UnityEngine;
using System.Collections.Generic;
using Avrahamy.Math;
using Avrahamy.Meshes;
using BitStrap;

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


            Vector3 D1 = new Vector3(temp1Vector2.x, temp1Vector2.y, 0);
            Vector3 D2 = new Vector3(temp2Vector2.x, temp2Vector2.y, 0);
            Vector3 D3 = new Vector3(temp3Vector2.x, temp3Vector2.y, 0);
            Vector3 D4 = new Vector3(temp4Vector2.x, temp4Vector2.y, 0);
            Vector3 D5 = new Vector3(temp5Vector2.x, temp5Vector2.y, 0);
            Vector3 D6 = new Vector3(temp6Vector2.x, temp6Vector2.y, 0);
            Vector3 D7 = new Vector3(temp7Vector2.x, temp7Vector2.y, 0);
            Vector3 D8 = new Vector3(temp8Vector2.x, temp8Vector2.y, 0);
            Vector3 D9 = new Vector3(temp9Vector2.x, temp9Vector2.y, 0);
            Vector3 D10 = new Vector3(temp10Vector2.x, temp10Vector2.y, 0);
            Vector3 D11 = new Vector3(temp11Vector2.x, temp11Vector2.y, 0);
            Vector3 D12 = new Vector3(temp12Vector2.x, temp12Vector2.y, 0);
            Vector3 D13 = new Vector3(temp13Vector2.x, temp13Vector2.y, 0);
            Vector3 D14 = new Vector3(temp14Vector2.x, temp14Vector2.y, 0);
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

            Vector3 D1B = new Vector3(temp1Vector2.x, temp1Vector2.y, 0.2f);
            Vector3 D2B = new Vector3(temp2Vector2.x, temp2Vector2.y, 0.2f);
            Vector3 D3B = new Vector3(temp3Vector2.x, temp3Vector2.y, 0.2f);
            Vector3 D4B = new Vector3(temp4Vector2.x, temp4Vector2.y, 0.2f);
            Vector3 D5B = new Vector3(temp5Vector2.x, temp5Vector2.y, 0.2f);
            Vector3 D6B = new Vector3(temp6Vector2.x, temp6Vector2.y, 0.2f);
            Vector3 D7B = new Vector3(temp7Vector2.x, temp7Vector2.y, 0.2f);
            Vector3 D8B = new Vector3(temp8Vector2.x, temp8Vector2.y, 0.2f);
            Vector3 D9B = new Vector3(temp9Vector2.x, temp9Vector2.y, 0.2f);
            Vector3 D10B = new Vector3(temp10Vector2.x, temp10Vector2.y, 0.2f);
            Vector3 D11B = new Vector3(temp11Vector2.x, temp11Vector2.y, 0.2f);
            Vector3 D12B = new Vector3(temp12Vector2.x, temp12Vector2.y, 0.2f);
            Vector3 D13B = new Vector3(temp13Vector2.x, temp13Vector2.y, 0.2f);
            Vector3 D14B = new Vector3(temp14Vector2.x, temp14Vector2.y, 0.2f);
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


            var points = new List<Vector3>(100)
            {
                Z, A, B, C,
                D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14,
                //18
                L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12, L13, L14,
                //33
                E,

                ZB, AB, BB, CB,
                //38
                D1B, D2B, D3B, D4B, D5B, D6B, D7B, D8B, D9B, D10B, D11B, D12B, D13B, D14B,
                //53
                L1B, L2B, L3B, L4B, L5B, L6B, L7B, L8B, L9B, L10B, L11B, L12B, L13B, L14B,
                //68
                EB
            };

            var triangles = new[]
            {
                //up 
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

                
                // //14
                33,41,40,
                33,42,41,
                33,43,42,
                33,44,43,
                33,45,44,
                33,46,45,
                
                33,47,46,
                33,48,47,
                33,49,48,
                33,50,49,
                33,51,50,
                33,52,51,
                33,53,52,
                33,55,54,
                



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
                
                //Down
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
                //ADD 33 AND REPLACE TGE TWO LAST 
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